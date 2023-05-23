using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Editor
{
    public partial class Window : Form
    {
        public enum DrawingTools
        {
            None = 0,
            Select,
            Ellipse,
            Line,
            Polygon,
            Rectangle,
            Pencil
        }

        public DrawingTools SelectedTool { get; set; }

        public enum MouseStates
        {
            Idle = 0,
            Moving,
            Pressing
        }

        public MouseStates MouseState { get; set; }

        public enum Elements
        {
            None = 0,
            DrawingIndicators,
            Ellipse,
            Line,
            Polygon,
            Rectangle,
            Pencil
        }

        public Elements DrawingType { get; set; }

        public enum KeyStates
        {
            None = 0,
            Pressing
        }

        public KeyStates KeyState { get; set; }

        private List<Shape> shapes = new List<Shape>();

        private Shape currentShape;
        private Shape selectedShape;
        private Rectangle selectionRectangle;
        private RectangleShapePropertiesWindow rectangleShapePropertiesWindow;
        private DimensionsWindow dimensionsWindow;
        private BorderThicknessWindow borderThicknessWindow;


        #region selectedShape Properties
        private Color borderColor,
            fillingColor;
        private bool hasFilling,
            hasBorder,
            drawDashedLine;
        private float[] dashes;
        private float borderThickness;
        private Shape highlightedShape;
        private bool isDrawingAdorners;
        private bool isDragging;
        private bool isResizing;
        #endregion

        public Window()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            horizontalRuler.ContextMenu = horizontalRulerContextMenu;
            verticalRuler.ContextMenu = verticalRulerContextMenu;

            rectangleShapePropertiesWindow = new RectangleShapePropertiesWindow();
            borderThicknessWindow = new BorderThicknessWindow();
            dimensionsWindow = new DimensionsWindow();
            dimensionsWindow.okButton.Click += OkButton_Click;
            borderThicknessWindow.okButton.Click += OkButton_Click1;
        }

        // This is for the BorderThicknessWindow.
        private void OkButton_Click1(object sender, EventArgs e)
        {
            float borderThickness;

            float.TryParse(borderThicknessWindow.borderThicknessTextField.Text, out borderThickness);

            if (currentShape != null)
            {
                currentShape.BorderThickness = borderThickness;

                if (currentShape.ShapeType == Shape.ShapeTypes.Rectangle)
                {
                    SelectedTool = DrawingTools.Rectangle;
                }

                this.Refresh();
            }
        }

        // This is for the DimensionsWindow.
        private void OkButton_Click(object sender, EventArgs e)
        {
            // Do work.
            int top,
                left,
                width,
                height;

            Int32.TryParse(dimensionsWindow.topTextField.Text, out top);
            Int32.TryParse(dimensionsWindow.leftTextField.Text, out left);
            Int32.TryParse(dimensionsWindow.widthTextField.Text, out width);
            Int32.TryParse(dimensionsWindow.heightTextField.Text, out height);

            if (currentShape != null)
            {
                currentShape.ShapeType = Shape.ShapeTypes.Rectangle;
                SelectedTool = DrawingTools.Rectangle;

                currentShape.Bounds = new Rectangle(
                    left,
                    top,
                    width,
                    height
                    );
            }

            dimensionsWindow.Hide();

            this.Refresh();
        }

        private void SelectCanvas()
        {
            if (canvas.CanSelect)
            {
                canvas.Select();
            }
        }

        private void canvas_SizeChanged(object sender, EventArgs e)
        {
            ResizeRulers();
        }

        private void ResizeRulers()
        {
            horizontalRuler.Width = canvas.Width;
            horizontalRuler.Left = canvas.Left;

            verticalRuler.Height = canvas.Height;
            verticalRuler.Top = canvas.Top;
        }

        private void Window_SizeChanged(object sender, EventArgs e)
        {
            ResizeRulers();
        }

        private void DrawRulerIndicators(MouseEventArgs e)
        {
            int xLocation = e.Location.X;
            int yLocation = e.Location.Y;

            horizontalRuler.DrawIndicator(
                xLocation
                );

            verticalRuler.DrawIndicator(
                yLocation
                );
        }

        private void clearAllMarkersContextMenuItem_Click(object sender, EventArgs e)
        {
            horizontalRuler.ClearMarker(
                Ruler.Markers.All
                );
        }

        private void clearCurrentMarkerContextMenuItem_Click(object sender, EventArgs e)
        {
            horizontalRuler.ClearMarker(
                Ruler.Markers.Current
                );
        }

        private void clearAllVerticalRulerMarkersContextMenuItem_Click(object sender, EventArgs e)
        {
            verticalRuler.ClearMarker(
                Ruler.Markers.All
                );
        }

        private void clearCurrentVerticalRulerMarkerContextMenuItem_Click(object sender, EventArgs e)
        {
            verticalRuler.ClearMarker(
                Ruler.Markers.Current
                );
        }

        private void canvas_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandlePressedKeyAndCheckAndUncheckCorrectMenuItems(e);
        }

        private void HandlePressedKeyAndCheckAndUncheckCorrectMenuItems(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 's':
                    SelectedTool = DrawingTools.Select;

                    selectToolMenuItem.Checked = true;

                    ellipseToolMenuItem.Checked = false;
                    lineToolMenuItem.Checked = false;
                    polygonToolMenuItem.Checked = false;
                    rectangleToolMenuItem.Checked = false;

                    statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Select.";
                    break;
                case 'e':
                    SelectedTool = DrawingTools.Ellipse;

                    ellipseToolMenuItem.Checked = true;

                    lineToolMenuItem.Checked = false;
                    rectangleToolMenuItem.Checked = false;
                    polygonToolMenuItem.Checked = false;
                    selectToolMenuItem.Checked = false;

                    statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Ellipse.";
                    break;
                case 'l':
                    SelectedTool = DrawingTools.Line;

                    lineToolMenuItem.Checked = true;

                    ellipseToolMenuItem.Checked = false;
                    rectangleToolMenuItem.Checked = false;
                    polygonToolMenuItem.Checked = false;
                    selectToolMenuItem.Checked = false;

                    statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Line.";
                    break;
                case 'p':
                    SelectedTool = DrawingTools.Polygon;

                    polygonToolMenuItem.Checked = true;

                    lineToolMenuItem.Checked = false;
                    rectangleToolMenuItem.Checked = false;
                    ellipseToolMenuItem.Checked = false;
                    selectToolMenuItem.Checked = false;

                    statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Polygon.";
                    break;
                case 'r':
                    SelectedTool = DrawingTools.Rectangle;

                    rectangleToolMenuItem.Checked = true;

                    lineToolMenuItem.Checked = false;
                    ellipseToolMenuItem.Checked = false;
                    polygonToolMenuItem.Checked = false;
                    selectToolMenuItem.Checked = false;

                    statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Rectangle.";
                    FillCurrentRectangleShapeProperties();
                    break;
            }
        }

        private void FillCurrentRectangleShapeProperties()
        {
            // Fill the Shape properties.
            if (currentShape == null)
            {
                currentShape = new Shape();
            }

            currentShape.ShapeType = Shape.ShapeTypes.Rectangle;
            currentShape.HasBorder = hasBorder;
            currentShape.BorderThickness = borderThickness;
            currentShape.LineStyle = drawDashedLine ? Shape.LineStyles.Dashed : Shape.LineStyles.Solid;
            currentShape.Dashes = dashes;
            currentShape.Coloring.BorderColor = borderColor;

            if (hasFilling)
            {
                currentShape.Coloring.HasFilling = hasFilling;
                currentShape.Coloring.Fillings.Color = fillingColor;
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocations.First = e.Location;
            MouseState = MouseStates.Pressing;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLocations.Current = e.Location;

            MouseState |= MouseStates.Moving;

            DrawRulerIndicators(e);

            if (MouseState.HasFlag(MouseStates.Pressing))
            {
                // Determine which tool to draw with.
                switch (SelectedTool)
                {
                    case DrawingTools.Select:
                        if (currentShape != null)
                        {
                            switch (currentShape.ShapeType)
                            {
                                case Shape.ShapeTypes.Rectangle:
                                    if (IsMouseWithinBoundsOfRectangle(currentShape))
                                    {
                                        // Move the shape around with the user.
                                        currentShape.Bounds = new Rectangle(
                                            currentShape.Bounds.Width + MouseLocations.Current.X - MouseLocations.First.X,
                                                            currentShape.Bounds.Height + MouseLocations.Current.Y - MouseLocations.First.Y,
                                                            currentShape.Bounds.Width,
                                                            currentShape.Bounds.Height
                                                            );

                                        isDragging = true;

                                        statusBar.Panels["elementInformationPanel"].Text = "Element Location: " + currentShape.Bounds.Location.X.ToString() + " x " + currentShape.Bounds.Location.Y.ToString() + ", Element Size: " + currentShape.Bounds.Width.ToString() + " x " + currentShape.Bounds.Height.ToString() + ".";

                                        this.Refresh();
                                    }
                                    break;
                                case Shape.ShapeTypes.Pixel:
                                    foreach (Pixel pixel in currentShape.Pixels)
                                    {
                                        if (MouseLocations.Current.X >= pixel.Bounds.X && MouseLocations.Current.X <= (pixel.Bounds.X + pixel.Bounds.Width) && MouseLocations.Current.Y >= pixel.Bounds.X && MouseLocations.Current.Y <= (pixel.Bounds.Y + pixel.Bounds.Height))
                                        {
                                            pixel.Highlighted = true;

                                            this.Refresh();
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            // Draw a selection rectangle.
                            int x,
                                y;
                            x = MouseLocations.Current.X;
                            y = MouseLocations.Current.Y;

                            selectionRectangle = new Rectangle(
                                MouseLocations.First.X,
                                MouseLocations.First.Y,
                                x -= MouseLocations.First.X,
                                y -= MouseLocations.First.Y
                                );
                        }

                        this.Refresh();
                        break;
                    case DrawingTools.Ellipse:
                        break;
                    case DrawingTools.Line:
                        break;
                    case DrawingTools.Polygon:
                        break;
                    case DrawingTools.Rectangle:
                        DrawingType = Elements.Rectangle;

                        int xLocation = 0,
                            yLocation = 0;
                        xLocation = MouseLocations.Current.X;
                        yLocation = MouseLocations.Current.Y;

                        if (currentShape != null)
                        {
                            currentShape.Bounds = new Rectangle(
                                MouseLocations.First.X,
                                MouseLocations.First.Y,
                                xLocation -= MouseLocations.First.X,
                                yLocation -= MouseLocations.First.Y
                                );
                        }

                        this.Refresh();
                        break;
                    case DrawingTools.Pencil:
                        DrawingType = Elements.Pencil;

                        int xPencilLocation = 0,
                            yPencilLocation = 0;

                        xPencilLocation = MouseLocations.Current.X;
                        yPencilLocation = MouseLocations.Current.Y;

                        if (currentShape != null)
                        {
                            currentShape.Pixels.Add(new Pixel()
                            {
                                Color = fillingColor,
                                Bounds = new Rectangle(
                                    MouseLocations.Current.X,
                                    MouseLocations.Current.Y,
                                    1,
                                    1
                                    )
                            });

                            this.Refresh();
                        }
                        break;
                }
            }

            if (!isDragging)
            {
                // Determine whether mouse is within bounds of a shape.
                // If it is, highlight the shape.
                if (shapes != null)
                {
                    if (shapes.Count >= 1)
                    {
                        foreach (Shape shape in shapes)
                        {
                            switch (shape.ShapeType)
                            {
                                case Shape.ShapeTypes.Rectangle:
                                    if (IsMouseWithinBoundsOfRectangle(shape))
                                    {
                                        shape.Highlighted = true;
                                        highlightedShape = shape;

                                        this.Refresh();
                                        break;
                                    }
                                    else
                                    {
                                        shape.Highlighted = false;

                                        this.Refresh();
                                    }
                                    break;
                                case Shape.ShapeTypes.Pixel:
                                    foreach (Pixel pixel in shape.Pixels)
                                    {
                                        if (MouseLocations.Current.X >= pixel.Bounds.X && MouseLocations.Current.X <= (pixel.Bounds.X + pixel.Bounds.Width) && MouseLocations.Current.Y >= pixel.Bounds.X && MouseLocations.Current.Y <= (pixel.Bounds.Y + pixel.Bounds.Height))
                                        {
                                            shape.Highlighted = true;
                                            highlightedShape = shape;

                                            this.Refresh();
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
            }

            // Determine whether to get the locations for adorners.
            foreach (Shape shape in shapes)
            {
                if (shape != null)
                {
                    switch (shape.ShapeType)
                    {
                        case Shape.ShapeTypes.Rectangle:
                            if (MouseLocations.Current.X >= (shape.Bounds.X + shape.Bounds.Width) - 6 && MouseLocations.Current.X <= (shape.Bounds.X + shape.Bounds.Width) + 6 && MouseLocations.Current.Y >= (shape.Bounds.Y + shape.Bounds.Height) - 6 && MouseLocations.Current.Y <= (shape.Bounds.Y + shape.Bounds.Height + 6))
                            {
                                shape.InitialSize = shape.Bounds.Size;
                                highlightedShape = shape;

                                isDrawingAdorners = true;
                                isResizing = true;

                                this.Refresh();
                            }
                            else
                            {
                                this.Cursor = Cursors.Default;
                            }
                            break;
                        case Shape.ShapeTypes.Pixel:
                            foreach (Pixel pixel in shape.Pixels)
                            {
                                if (MouseLocations.Current.X >= pixel.Bounds.X && MouseLocations.Current.X <= (pixel.Bounds.X + pixel.Bounds.Width) && MouseLocations.Current.Y >= pixel.Bounds.X && MouseLocations.Current.Y <= (pixel.Bounds.Y + pixel.Bounds.Height))
                                {
                                    shape.InitialSize = shape.Bounds.Size;
                                    highlightedShape = shape;

                                    isDrawingAdorners = true;
                                    isResizing = false;

                                    this.Refresh();
                                }
                                else
                                {
                                    this.Cursor = Cursors.Default;
                                }
                            }
                            break;
                    }
                }
            }

            if (isResizing)
            {
                if (MouseState.HasFlag(MouseStates.Pressing))
                {
                    if (SelectedTool == DrawingTools.Select)
                    {
                        if (highlightedShape != null)
                        {
                            if (highlightedShape.ShapeType == Shape.ShapeTypes.Rectangle)
                            {
                                Size initialHighlightedShapeSize = highlightedShape.InitialSize;

                                highlightedShape.Bounds = new Rectangle(
                                    highlightedShape.Bounds.X,
                                    highlightedShape.Bounds.Y,
                                    highlightedShape.InitialSize.Width + MouseLocations.Current.X - MouseLocations.First.X,
                                    highlightedShape.InitialSize.Height + MouseLocations.Current.Y - MouseLocations.First.Y
                                    );

                                statusBar.Panels["drawingToolInformationPanel"].Text = "Element size: " + highlightedShape.Bounds.Width.ToString() + "px x " + highlightedShape.Bounds.Height.ToString() + "px.";

                                this.Refresh();
                            }
                        }
                    }
                }
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            MouseLocations.Last = e.Location;
            MouseState -= MouseStates.Pressing;

            statusBar.Panels["drawingToolInformationPanel"].Text = "Selected Tool: " + SelectedTool.ToString() + ".";

            isDragging = false;
            isResizing = false;

            if (SelectedTool != DrawingTools.Select)
            {
                if (currentShape != null)
                {
                    shapes.Add(currentShape);
                    currentShape = null;
                }
            }

            if (highlightedShape != null)
            {
                switch (highlightedShape.ShapeType)
                {
                    case Shape.ShapeTypes.Rectangle:
                        if (IsMouseWithinBoundsOfRectangle(highlightedShape))
                        {
                            highlightedShape.Selected = true;
                            currentShape = highlightedShape;
                            statusBar.Panels["elementInformationPanel"].Text = "Element Location: " + currentShape.Bounds.Location.X.ToString() + " x " + currentShape.Bounds.Location.Y.ToString() + ", Element Size: " + currentShape.Bounds.Width.ToString() + " x " + currentShape.Bounds.Height.ToString() + ".";

                        }
                        else
                        {
                            highlightedShape.Selected = false;
                        }
                        break;
                    case Shape.ShapeTypes.Pixel:
                        foreach (Pixel pixel in highlightedShape.Pixels)
                        {
                            if (MouseLocations.Current.X >= pixel.Bounds.X && MouseLocations.Current.X <= (pixel.Bounds.X + pixel.Bounds.Width) && MouseLocations.Current.Y >= pixel.Bounds.X && MouseLocations.Current.Y <= (pixel.Bounds.Y + pixel.Bounds.Height))
                            {
                                highlightedShape.Selected = true;
                                highlightedShape.Pixels[highlightedShape.Pixels.IndexOf(pixel)] = pixel;
                                pixel.Selected = true;
                                currentShape = highlightedShape;
                                statusBar.Panels["elementInformationPanel"].Text = "Element Location: " + pixel.Bounds.Location.X.ToString() + " x " + pixel.Bounds.Location.Y.ToString() + ", Element Size: " + pixel.Bounds.Width.ToString() + " x " + pixel.Bounds.Height.ToString() + ".";
                            }
                            else
                            {
                                highlightedShape.Selected = false;
                            }
                        }
                        break;
                }
            }

            // Deselect all selected shapes if the mouse
            // is not within the bounds of the rectangle.
            if (shapes != null)
            {
                if (shapes.Count >= 1)
                {
                    foreach (Shape shape in shapes)
                    {
                        if (!IsMouseWithinBoundsOfRectangle(shape))
                        {
                            if (shape.Selected)
                            {
                                shapes[shapes.IndexOf(shape)].Selected = false;
                            }
                        }
                    }
                }
            }

            if (currentShape != null)
            {
                if (currentShape.ShapeType == Shape.ShapeTypes.Pixel)
                {
                    shapes.Add(currentShape);
                }
            }

            this.Refresh();
        }

        private void canvas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Determine whether the Control modifier is being pressed
            // so we can display the drawing indicators.
            switch (e.Modifiers)
            {
                case Keys.Control:
                    // Draw the Drawing Indicators.
                    DrawingType = Elements.DrawingIndicators;
                    break;
                default:
                    DrawingType = Elements.None;
                    break;
            }

            if (currentShape != null)
            {
                if (currentShape.Selected)
                {
                    KeyState = KeyStates.Pressing;

                    isResizing = true;

                    // Determine keys pressed to allow for resizing of controls via keyboard shortcuts.
                    if (e.Modifiers == Keys.Shift)
                    {
                        if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Shift)
                        {
                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width + 1,
                                    currentShape.Bounds.Height
                                    );

                                this.Refresh();
                            }
                        }
                        else if (e.KeyCode == Keys.Left && e.Modifiers == Keys.Shift)
                        {
                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width - 1,
                                    currentShape.Bounds.Height
                                    );

                                this.Refresh();
                            }
                        }
                        else if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Shift)
                        {

                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width,
                                    currentShape.Bounds.Height - 1
                                    );

                                this.Refresh();
                            }
                        }
                        else if (e.KeyCode == Keys.Down && e.Modifiers == Keys.Shift)
                        {

                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width,
                                    currentShape.Bounds.Height + 1
                                    );

                                this.Refresh();
                            }
                        }
                    }
                    else if (e.Modifiers == Keys.Control)
                    {
                        // Move fast.
                        // Move the control with the arrow keys.
                        if (e.KeyCode == Keys.Left)
                        {
                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X - 10,
                                currentShape.Bounds.Y,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }
                        else if (e.KeyCode == Keys.Right)
                        {
                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X + 10,
                                currentShape.Bounds.Y,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }
                        else if (e.KeyCode == Keys.Up)
                        {

                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X,
                                currentShape.Bounds.Y - 10,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }
                        else if (e.KeyCode == Keys.Down)
                        {

                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X,
                                currentShape.Bounds.Y + 10,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }
                    }
                    else if (e.Modifiers.HasFlag(Keys.Control) && e.Modifiers.HasFlag(Keys.Shift))
                    {
                        // resize fast.
                        if (e.KeyCode == Keys.Right)
                        {
                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width + 10,
                                    currentShape.Bounds.Height
                                    );

                                this.Refresh();
                            }
                        }
                        else if (e.KeyCode == Keys.Left)
                        {
                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width - 10,
                                    currentShape.Bounds.Height
                                    );

                                this.Refresh();
                            }
                        }
                        else if (e.KeyCode == Keys.Up)
                        {
                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width,
                                    currentShape.Bounds.Height - 10
                                    );

                                this.Refresh();
                            }
                        }
                        else if (e.KeyCode == Keys.Down)
                        {

                            Console.WriteLine("Resize enabled.");

                            if (currentShape != null)
                            {
                                currentShape.Bounds = new Rectangle(
                                    currentShape.Bounds.X,
                                    currentShape.Bounds.Y,
                                    currentShape.Bounds.Width,
                                    currentShape.Bounds.Height + 10
                                    );

                                this.Refresh();
                            }
                        }
                    }
                    else
                    {
                        // Move the control with the arrow keys.
                        if (e.KeyCode == Keys.Left)
                        {
                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X - 1,
                                currentShape.Bounds.Y,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }
                        else if (e.KeyCode == Keys.Right)
                        {
                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X + 1,
                                currentShape.Bounds.Y,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }
                        else if (e.KeyCode == Keys.Up)
                        {

                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X,
                                currentShape.Bounds.Y - 1,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }
                        else if (e.KeyCode == Keys.Down)
                        {

                            currentShape.Bounds = new Rectangle(
                                currentShape.Bounds.X,
                                currentShape.Bounds.Y + 1,
                                currentShape.Bounds.Width,
                                currentShape.Bounds.Height
                                );

                            this.Refresh();
                        }

                        if (currentShape != null)
                        {
                            statusBar.Panels["drawingToolInformationPanel"].Text = "Element location: " + currentShape.Bounds.X + " x " + currentShape.Bounds.Y + ", " + "Element size: " + currentShape.Bounds.Width.ToString() + "px x " + currentShape.Bounds.Height.ToString() + "px.";
                        }

                    }
                }
            }


            this.Refresh();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            switch (SelectedTool)
            {
                case DrawingTools.Select:
                    if (isDragging)
                    {
                        if (currentShape != null)
                        {
                            switch (currentShape.ShapeType)
                            {
                                case Shape.ShapeTypes.Pixel:
                                    foreach (Pixel pixel in currentShape.Pixels)
                                    {
                                        if (pixel.Selected)
                                        {
                                            using (Pen pen = new Pen(
                                                new SolidBrush(
                                                    pixel.Color
                                                    ),
                                                0.01f
                                                )
                                            )
                                            {
                                                e.Graphics.DrawRectangle(
                                                    pen,
                                                    new Rectangle(
                                                        pixel.Bounds.Width + MouseLocations.Current.X - MouseLocations.First.X,
                                                        pixel.Bounds.Height + MouseLocations.Current.Y - MouseLocations.First.Y,
                                                        pixel.Bounds.Width,
                                                        pixel.Bounds.Height
                                                        )
                                                    );
                                            }
                                        }
                                    }
                                    break;
                                case Shape.ShapeTypes.Rectangle:
                                    if (currentShape.LineStyle == Shape.LineStyles.Dashed)
                                    {
                                        if (currentShape.HasBorder)
                                        {
                                            using (Pen pen = new Pen(
                                                new SolidBrush(
                                                    currentShape.Coloring.BorderColor
                                                    ),
                                                currentShape.BorderThickness
                                                )
                                                )
                                            {
                                                pen.DashPattern = currentShape.Dashes;

                                                e.Graphics.DrawRectangle(
                                                    pen,
                                                    currentShape.Bounds
                                                    );
                                            }

                                            if (currentShape.Coloring.HasFilling)
                                            {
                                                e.Graphics.FillRectangle(
                                                    new SolidBrush(
                                                        currentShape.Coloring.Fillings.Color
                                                        ),
                                                        currentShape.Bounds
                                                    );
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (currentShape.HasBorder)
                                        {
                                            using (Pen pen = new Pen(
                                                currentShape.Coloring.BorderColor,
                                                currentShape.BorderThickness
                                                )
                                                )
                                            {
                                                e.Graphics.DrawRectangle(
                                                    pen,
                                                    currentShape.Bounds
                                                    );
                                            }
                                        }
                                        else
                                        {
                                            e.Graphics.FillRectangle(
                                                new SolidBrush(
                                                    currentShape.Coloring.Fillings.Color
                                                    ),
                                                currentShape.Bounds
                                                );
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (!isResizing)
                        {
                            DrawSelectionRectangle(e);
                        }
                    }
                    break;
                case DrawingTools.Rectangle:
                    if (currentShape != null)
                    {
                        if (drawDashedLine)
                        {
                            using (Pen pen = new Pen(
                                new SolidBrush(
                                    currentShape.Coloring.BorderColor
                                    ),
                                currentShape.BorderThickness
                                )
                                )
                            {
                                pen.DashPattern = currentShape.Dashes;

                                e.Graphics.DrawRectangle(
                                    pen,
                                    currentShape.Bounds
                                    );
                            }

                            if (currentShape.Coloring.HasFilling)
                            {
                                e.Graphics.FillRectangle(
                                    new SolidBrush(
                                        currentShape.Coloring.Fillings.Color
                                        ),
                                    currentShape.Bounds
                                    );
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(
                                new SolidBrush(
                                    currentShape.Coloring.BorderColor
                                    ),
                                currentShape.BorderThickness
                                )
                                )
                            {
                                e.Graphics.DrawRectangle(
                                    pen,
                                    currentShape.Bounds
                                    );
                            }

                            if (currentShape.Coloring.HasFilling)
                            {
                                e.Graphics.FillRectangle(
                                    new SolidBrush(
                                        currentShape.Coloring.Fillings.Color
                                        ),
                                    currentShape.Bounds
                                    );
                            }
                        }
                    }
                    break;
                case DrawingTools.Pencil:
                    if (currentShape != null)
                    {
                        foreach (Pixel pixel in currentShape.Pixels)
                        {
                            using (Pen pen = new Pen(
                                new SolidBrush(
                                    pixel.Color
                                    ),
                                1.0f
                                )
                                )
                            {
                                e.Graphics.DrawRectangle(
                                    pen,
                                    pixel.Bounds
                                    );
                            }
                        }
                    }
                    break;
            }

            #region Draw all shapes
            if (shapes != null)
            {
                if (shapes.Count >= 1)
                {
                    foreach (Shape shape in shapes)
                    {
                        switch (shape.ShapeType)
                        {
                            case Shape.ShapeTypes.Pixel:
                                foreach (Pixel pixel in shape.Pixels)
                                {
                                    using (Pen pen = new Pen(
                                        new SolidBrush(
                                            pixel.Color
                                            ),
                                        0.01f
                                        )
                                        )
                                    {
                                        e.Graphics.DrawRectangle(
                                            pen,
                                            pixel.Bounds
                                            );
                                    }
                                }
                                break;
                            case Shape.ShapeTypes.Rectangle:
                                if (shape.LineStyle == Shape.LineStyles.Dashed)
                                {
                                    if (shape.HasBorder)
                                    {
                                        using (Pen pen = new Pen(
                                            new SolidBrush(
                                                shape.Coloring.BorderColor
                                                ),
                                            shape.BorderThickness
                                            )
                                            )
                                        {
                                            pen.DashPattern = shape.Dashes;

                                            e.Graphics.DrawRectangle(
                                                pen,
                                                shape.Bounds
                                                );
                                        }

                                        if (shape.Coloring.HasFilling)
                                        {
                                            e.Graphics.FillRectangle(
                                                new SolidBrush(
                                                    shape.Coloring.Fillings.Color
                                                    ),
                                                shape.Bounds
                                                );
                                        }
                                    }
                                    else
                                    {
                                        if (shape.Coloring.HasFilling)
                                        {
                                            e.Graphics.FillRectangle(
                                                new SolidBrush(
                                                    shape.Coloring.Fillings.Color
                                                    ),
                                                shape.Bounds
                                                );
                                        }
                                    }
                                }
                                else
                                {
                                    if (shape.HasBorder)
                                    {
                                        using (Pen pen = new Pen(
                                            new SolidBrush(
                                                shape.Coloring.BorderColor
                                                ),
                                            shape.BorderThickness
                                            )
                                            )
                                        {
                                            e.Graphics.DrawRectangle(
                                                pen,
                                                shape.Bounds
                                                );
                                        }

                                        if (shape.Coloring.HasFilling)
                                        {
                                            e.Graphics.FillRectangle(
                                                new SolidBrush(
                                                    shape.Coloring.Fillings.Color
                                                    ),
                                                shape.Bounds
                                                );
                                        }
                                    }
                                    else
                                    {
                                        if (shape.Coloring.HasFilling)
                                        {
                                            e.Graphics.FillRectangle(
                                                new SolidBrush(
                                                    shape.Coloring.Fillings.Color
                                                    ),
                                                shape.Bounds
                                                );
                                        }
                                    }
                                }

                                break;
                        }
                    }
                }
            }
            #endregion

            #region Draw adorners around highlighted shapes.
            if (shapes != null)
            {
                if (shapes.Count >= 1)
                {
                    foreach (Shape shape in shapes)
                    {
                        if (shape.Highlighted)
                        {
                            DrawAdornersAroundHighlightedShape(e, shape);
                        }
                        else if (shape.Selected)
                        {
                            DrawAdornersAroundHighlightedShape(e, shape);
                        }
                    }
                }
            }
            #endregion

            if (isResizing)
            {
                if (highlightedShape != null)
                {
                    if (highlightedShape.ShapeType == Shape.ShapeTypes.Rectangle)
                    {
                        if (highlightedShape.LineStyle == Shape.LineStyles.Dashed)
                        {
                            if (highlightedShape.HasBorder)
                            {
                                using (Pen pen = new Pen(
                                    new SolidBrush(
                                        highlightedShape.Coloring.BorderColor
                                        ),
                                    highlightedShape.BorderThickness
                                    )
                                    )
                                {
                                    pen.DashPattern = highlightedShape.Dashes;

                                    e.Graphics.DrawRectangle(
                                        pen,
                                        highlightedShape.Bounds
                                        );
                                }

                                if (highlightedShape.Coloring.HasFilling)
                                {
                                    e.Graphics.FillRectangle(
                                        new SolidBrush(
                                            highlightedShape.Coloring.Fillings.Color
                                            ),
                                        highlightedShape.Bounds
                                        );
                                }
                            }
                            else
                            {
                                if (highlightedShape.Coloring.HasFilling)
                                {
                                    e.Graphics.FillRectangle(
                                        new SolidBrush(
                                            highlightedShape.Coloring.Fillings.Color
                                            ),
                                        highlightedShape.Bounds
                                        );
                                }
                            }
                        }
                        else
                        {
                            if (highlightedShape.HasBorder)
                            {
                                using (Pen pen = new Pen(
                                    new SolidBrush(
                                        highlightedShape.Coloring.BorderColor
                                        ),
                                    highlightedShape.BorderThickness
                                    )
                                    )
                                {
                                    e.Graphics.DrawRectangle(
                                        pen,
                                        highlightedShape.Bounds
                                        );
                                }

                                if (highlightedShape.Coloring.HasFilling)
                                {
                                    e.Graphics.FillRectangle(
                                        new SolidBrush(
                                            highlightedShape.Coloring.Fillings.Color
                                            ),
                                        highlightedShape.Bounds
                                        );
                                }
                            }
                            else
                            {
                                if (highlightedShape.Coloring.HasFilling)
                                {
                                    e.Graphics.FillRectangle(
                                        new SolidBrush(
                                            highlightedShape.Coloring.Fillings.Color
                                            ),
                                        highlightedShape.Bounds
                                        );
                                }
                            }
                        }
                    }
                }
            }

            // Draw each element as it is being drawn by the user.
            switch (DrawingType)
            {
                case Elements.DrawingIndicators:
                    DrawDrawingIndicators(e);
                    break;
            }
        }

        private static void DrawAdornersAroundHighlightedShape(PaintEventArgs e, Shape shape)
        {
            // Draw the Top-left adorner.
            Rectangle topLeftAdornerBorderRectangle = new Rectangle(
                (shape.Bounds.X - 5),
                (shape.Bounds.Y - 5),
                10,
                10
                );

            Rectangle topLeftAdornerFillingRectangle = new Rectangle(
                (shape.Bounds.X - 5),
                (shape.Bounds.Y - 5),
                10,
                10
                );

            e.Graphics.DrawRectangle(
                new Pen(
                    Color.FromArgb(
                        245, 215, 163
                        ),
                    1.0f),
                topLeftAdornerBorderRectangle
                );

            e.Graphics.FillRectangle(
                new SolidBrush(
                    Color.FromArgb(
                    242, 231, 208
                    )
                    ),
                topLeftAdornerFillingRectangle
                );

            // Draw top-right adorner.
            Rectangle topRightAdornerBorderRectangle = new Rectangle(
                (shape.Bounds.X + shape.Bounds.Width - 5),
                (shape.Bounds.Y - 5),
                10,
                10
                );

            Rectangle topRightFillingRectangle = new Rectangle(
                (shape.Bounds.X + shape.Bounds.Width - 5),
                (shape.Bounds.Y - 5),
                10,
                10
                );

            e.Graphics.DrawRectangle(
                new Pen(
                    new SolidBrush(
                        Color.FromArgb(
                            245, 215, 163
                            )
                        ),
                    1.0f
                    ),
                topRightAdornerBorderRectangle
                );

            e.Graphics.FillRectangle(
                new SolidBrush(
                    Color.FromArgb(
                        242, 231, 208
                    )
                    ),
                topRightFillingRectangle
                );

            Rectangle bottomRightAdornerBorderRectangle = new Rectangle(
                (shape.Bounds.X + shape.Bounds.Width - 5),
                (shape.Bounds.Y + shape.Bounds.Height - 5),
                10,
                10
                );

            Rectangle bottomRightAdornerFillingRectangle = new Rectangle(
                (shape.Bounds.X + shape.Bounds.Width - 5),
                (shape.Bounds.Y + shape.Bounds.Height - 5),
                10,
                10
                );

            e.Graphics.DrawRectangle(
                new Pen(
                    new SolidBrush(
                        Color.FromArgb(
                            245, 215, 163
                            )
                        ),
                    1.0f
                    ),
                bottomRightAdornerBorderRectangle
                );

            e.Graphics.FillRectangle(
                new SolidBrush(
                    Color.FromArgb(
                        242, 231, 208
                        )
                    ),
                bottomRightAdornerFillingRectangle
                );

            Rectangle bottomLeftAdornerBorderRectangle = new Rectangle(
                (shape.Bounds.X - 5),
                (shape.Bounds.Y + shape.Bounds.Height - 5),
                10,
                10
                );

            e.Graphics.DrawRectangle(
                new Pen(
                    new SolidBrush(
                    Color.FromArgb(
                        245, 215, 163
                        )
                    ),
                    1.0f
                    ),
                bottomLeftAdornerBorderRectangle
                );

            Rectangle bottomLeftAdornerFillingRectangle = new Rectangle(
                (shape.Bounds.X - 5),
                (shape.Bounds.Y + shape.Bounds.Height - 5),
                10,
                10
                );

            e.Graphics.FillRectangle(
                new SolidBrush(
                    Color.FromArgb(
                        242, 231, 208
                        )
                    ),
                bottomLeftAdornerFillingRectangle
                );
        }

        private bool IsMouseWithinBoundsOfRectangle(Shape shape)
        {
            if (MouseLocations.Current.X >= shape.Bounds.X && MouseLocations.Current.X <= (shape.Bounds.X + shape.Bounds.Width) && MouseLocations.Current.Y >= shape.Bounds.Y && MouseLocations.Current.Y <= (shape.Bounds.X + shape.Bounds.Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DrawSelectionRectangle(PaintEventArgs e)
        {
            using (Pen pen = new Pen(
                new SolidBrush(
                    Color.FromArgb(
                        47, 253, 103
                        )
                    ),
                1.0f
                )
                )
            {
                e.Graphics.DrawRectangle(
                    pen,
                    selectionRectangle
                    );

                e.Graphics.FillRectangle(
                    new SolidBrush(
                        Color.FromArgb(
                            127, 183, 246, 204
                            )
                        ),
                    selectionRectangle
                    );
            }
        }

        private static void DrawDrawingIndicators(PaintEventArgs e)
        {
            using (Pen pen = new Pen(
                Color.FromArgb(
                    25, 134, 254
                    ),
                1.0f
                )
                )
            {
                pen.DashPattern = new float[]
                {
                    1.0f,
                    3.0f,
                    1.0f
                };

                e.Graphics.DrawLine(
                    pen,
                    new Point(
                        MouseLocations.Current.X,
                        0
                    ),
                    new Point(
                        MouseLocations.Current.X,
                        MouseLocations.Current.Y
                    )
                    );

                e.Graphics.DrawLine(
                    pen,
                    new Point(
                        0,
                        MouseLocations.Current.Y
                    ),
                    new Point(
                        MouseLocations.Current.X,
                        MouseLocations.Current.Y
                        )
                    );
            }

            string xLocationText = MouseLocations.Current.X.ToString() + " x " + MouseLocations.Current.Y + ".";

            SizeF xLocationTextSize = e.Graphics.MeasureString(
                xLocationText,
                new Font(
                    "Saira",
                    7.25f
                    )
                );

            Rectangle verticalAlignmentTextRectangle = new Rectangle(
                MouseLocations.Current.X,
                MouseLocations.Current.Y - (int)xLocationTextSize.Height - (3 * 2),
                ((int)xLocationTextSize.Width + (7 * 2)),
                ((int)xLocationTextSize.Height + (3 * 2))
                );

            using (Pen pen = new Pen(
                new SolidBrush(
                    Color.FromArgb(
                        245, 215, 163
                        )
                    ),
                1.0f
                )
                )
            {
                e.Graphics.DrawRectangle(
                    pen,
                    verticalAlignmentTextRectangle
                    );
            }

            e.Graphics.FillRectangle(
                new SolidBrush(
                    Color.FromArgb(
                        242, 231, 208
                        )
                    ),
                verticalAlignmentTextRectangle.X,
                verticalAlignmentTextRectangle.Y,
                verticalAlignmentTextRectangle.Width,
                verticalAlignmentTextRectangle.Height
                );

            e.Graphics.DrawString(
                xLocationText,
                new Font(
                    "Saira",
                    7.25f
                    ),
                Brushes.Black,
                new PointF(
                    (verticalAlignmentTextRectangle.X + verticalAlignmentTextRectangle.Width) - (verticalAlignmentTextRectangle.Width / 2) - (int)xLocationTextSize.Width / 2,
                    (verticalAlignmentTextRectangle.Y + verticalAlignmentTextRectangle.Height - (verticalAlignmentTextRectangle.Height / 2) - (int)xLocationTextSize.Height / 2)
                    )
                );
        }

        private void selectToolToolbarItem_Click(object sender, EventArgs e)
        {
            if (selectToolToolbarItem.Checked)
            {
                selectToolToolbarItem.Checked = false;

                selectToolMenuItem.Checked = false;

                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: None.";
            }
            else
            {
                selectToolToolbarItem.Checked = true;

                selectToolMenuItem.Checked = true;

                lineToolToolbarItem.Checked = false;
                polygonToolToolbarItem.Checked = false;
                rectangleToolToolbarItem.Checked = false;
                ellipseToolMenuItem.Checked = false;
                lineToolMenuItem.Checked = false;
                polygonToolMenuItem.Checked = false;
                rectangleToolMenuItem.Checked = false;
                pencilToolToolbarItem.Checked = false;

                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Select.";
            }

            // TODO: Uncheck other toolbar items from the "Drawing Tools" toolbar section.

            SelectedTool = DrawingTools.Select;
        }

        private void rectangleToolToolbarItem_Click(object sender, EventArgs e)
        {
            if (rectangleToolToolbarItem.Checked)
            {
                rectangleToolToolbarItem.Checked = false;

                rectangleToolMenuItem.Checked = false;

                SelectedTool = DrawingTools.None;

                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: " + SelectedTool.ToString();
            }
            else
            {
                rectangleToolToolbarItem.Checked = true;
                rectangleToolMenuItem.Checked = true;

                selectToolToolbarItem.Checked = false;
                lineToolToolbarItem.Checked = false;
                polygonToolToolbarItem.Checked = false;
                ellipseToolMenuItem.Checked = false;
                lineToolMenuItem.Checked = false;
                polygonToolMenuItem.Checked = false;
                selectToolMenuItem.Checked = false;
                pencilToolToolbarItem.Checked = false;

                SelectedTool = DrawingTools.Rectangle;

                FillCurrentRectangleShapeProperties();

                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Rectangle.";
            }

            // TODO: Uncheck other toolbar items from the "Drawing Tools" toolbar section.
        }

        private void lineToolToolbarItem_Click(object sender, EventArgs e)
        {
            if (lineToolToolbarItem.Checked)
            {
                lineToolToolbarItem.Checked = false;

                lineToolMenuItem.Checked = false;

                SelectedTool = DrawingTools.None;

                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: " + SelectedTool.ToString();
            }
            else
            {
                lineToolToolbarItem.Checked = true;
                lineToolMenuItem.Checked = true;

                selectToolToolbarItem.Checked = false;
                rectangleToolToolbarItem.Checked = false;
                polygonToolToolbarItem.Checked = false;
                ellipseToolMenuItem.Checked = false;
                rectangleToolMenuItem.Checked = false;
                selectToolMenuItem.Checked = false;
                lineToolMenuItem.Checked = false;
                polygonToolMenuItem.Checked = false;
                pencilToolToolbarItem.Checked = false;

                SelectedTool = DrawingTools.Rectangle;


                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Line.";
            }
        }

        private void polygonToolToolbarItem_Click(object sender, EventArgs e)
        {
            if (polygonToolToolbarItem.Checked)
            {
                polygonToolToolbarItem.Checked = false;

                polygonToolMenuItem.Checked = false;

                SelectedTool = DrawingTools.None;

                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: " + SelectedTool.ToString();
            }
            else
            {
                polygonToolToolbarItem.Checked = true;
                polygonToolMenuItem.Checked = true;

                selectToolToolbarItem.Checked = false;
                lineToolToolbarItem.Checked = false;
                ellipseToolMenuItem.Checked = false;
                lineToolMenuItem.Checked = false;
                rectangleToolMenuItem.Checked = false;
                rectangleToolToolbarItem.Checked = false;
                pencilToolToolbarItem.Checked = false;

                SelectedTool = DrawingTools.Rectangle;


                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Rectangle.";
            }
        }

        private void pencilToolToolbarItem_Click(object sender, EventArgs e)
        {
            if (pencilToolToolbarItem.Checked)
            {
                pencilToolToolbarItem.Checked = false;


                SelectedTool = DrawingTools.None;

                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: " + SelectedTool.ToString();
            }
            else
            {
                pencilToolToolbarItem.Checked = true;

                selectToolToolbarItem.Checked = false;
                lineToolToolbarItem.Checked = false;
                ellipseToolMenuItem.Checked = false;
                selectToolMenuItem.Checked = false;
                lineToolMenuItem.Checked = false;
                rectangleToolMenuItem.Checked = false;
                rectangleToolToolbarItem.Checked = false;
                polygonToolToolbarItem.Checked = false;
                polygonToolMenuItem.Checked = false;

                SelectedTool = DrawingTools.Pencil;


                currentShape = new Shape();
                currentShape.ShapeType = Shape.ShapeTypes.Pixel;
                currentShape.Coloring.Fillings.Color = fillingColor;


                statusBar.Panels["drawingToolInformationPanel"].Text = "Drawing Tool: Pencil.";
            }
        }

        private void dimensionsToolbarItem_Click(object sender, EventArgs e)
        {
            if (!dimensionsWindow.Visible)
            {
                if (currentShape != null)
                {
                    dimensionsWindow.topTextField.Text = currentShape.Bounds.Top.ToString();
                    dimensionsWindow.leftTextField.Text = currentShape.Bounds.Left.ToString();
                    dimensionsWindow.widthTextField.Text = currentShape.Bounds.Width.ToString();
                    dimensionsWindow.heightTextField.Text = currentShape.Bounds.Height.ToString();
                }

                dimensionsWindow.Show(this);
            }
        }

        private void dimensionsMenuItem_Click(object sender, EventArgs e)
        {
            if (!dimensionsWindow.Visible)
            {
                if (currentShape != null)
                {
                    dimensionsWindow.topTextField.Text = currentShape.Bounds.Top.ToString();
                    dimensionsWindow.leftTextField.Text = currentShape.Bounds.Left.ToString();
                    dimensionsWindow.widthTextField.Text = currentShape.Bounds.Width.ToString();
                    dimensionsWindow.heightTextField.Text = currentShape.Bounds.Height.ToString();
                }

                dimensionsWindow.Show();
            }
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            using (RectangleShapePropertiesWindow window = new RectangleShapePropertiesWindow())
            {
                if (window.ShowDialog(this) == DialogResult.OK)
                {
                    if (currentShape != null)
                    {
                        currentShape.BorderThickness = window.borderThickness;
                        currentShape.HasBorder = window.hasBorder;
                        currentShape.Coloring.BorderColor = window.borderColor;
                        currentShape.Coloring.HasFilling = window.hasFilling;
                        currentShape.Coloring.Fillings.Color = window.fillingColor;

                        if (window.drawDashedLine)
                        {
                            currentShape.LineStyle = Shape.LineStyles.Dashed;

                            currentShape.Dashes = window.dashes.ToArray<float>();
                        }
                        else
                        {
                            currentShape.LineStyle = Shape.LineStyles.Solid;
                        }
                    }

                    hasFilling = window.hasFilling;
                    borderColor = window.borderColor;
                    fillingColor = window.fillingColor;
                    hasBorder = window.hasBorder;
                    borderThickness = window.borderThickness;
                    drawDashedLine = window.drawDashedLine;
                    dashes = window.dashes.ToArray<float>();

                    if (currentShape != null)
                    {
                        currentShape.ShapeType = Shape.ShapeTypes.Rectangle;
                        currentShape.LineStyle = window.drawDashedLine ? currentShape.LineStyle = Shape.LineStyles.Dashed : Shape.LineStyles.Solid;
                        currentShape.BorderThickness = borderThickness;
                        currentShape.Dashes = dashes;
                        currentShape.HasBorder = window.hasBorder;
                        currentShape.Coloring.HasFilling = hasFilling;
                        currentShape.Coloring.BorderColor = borderColor;
                        currentShape.Coloring.Fillings.Color = fillingColor;
                    }
                }
            }
        }

        private void borderThicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!borderThicknessWindow.Visible)
            {
                borderThicknessWindow.Show();
            }
        }

        private void borderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    fillingColor = dialog.Color;

                    if (currentShape != null)
                    {
                        if (currentShape.ShapeType == Shape.ShapeTypes.Rectangle)
                        {
                            currentShape.Coloring.Fillings.Color = dialog.Color;
                            SelectedTool = DrawingTools.Rectangle;
                            this.Refresh();
                        }
                    }
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if(dialog.ShowDialog(this) == DialogResult.OK)
                {
                    fillingColor = dialog.Color;

                    if (currentShape != null)
                    {
                        currentShape.Coloring.Fillings.Color = fillingColor;

                        SelectedTool = DrawingTools.Rectangle;

                        this.Refresh();
                    }
                }
            }
        }

        private void Window_Shown(object sender, EventArgs e)
        {
            // This allows the ExtendedPanel to receive key presses before the
            // user clicks inside the ExtendedPanel to Select it.
            SelectCanvas();
        }

        private void canvas_KeyUp(object sender, KeyEventArgs e)
        {
            if (DrawingType == Elements.DrawingIndicators)
            {
                DrawingType = Elements.None;

                this.Refresh();
            }
        }

        private void elementPropertiesMenuItem_Click(object sender, EventArgs e)
        {
            using (RectangleShapePropertiesWindow window = new RectangleShapePropertiesWindow())
            {
                if (window.ShowDialog(this) == DialogResult.OK)
                {
                    if (currentShape != null)
                    {
                        currentShape.BorderThickness = window.borderThickness;
                        currentShape.HasBorder = window.hasBorder;
                        currentShape.Coloring.BorderColor = window.borderColor;
                        currentShape.Coloring.HasFilling = window.hasFilling;
                        currentShape.Coloring.Fillings.Color = window.fillingColor;

                        if (window.drawDashedLine)
                        {
                            currentShape.LineStyle = Shape.LineStyles.Dashed;

                            currentShape.Dashes = window.dashes.ToArray<float>();
                        }
                        else
                        {
                            currentShape.LineStyle = Shape.LineStyles.Solid;
                        }
                    }

                    hasFilling = window.hasFilling;
                    borderColor = window.borderColor;
                    fillingColor = window.fillingColor;
                    hasBorder = window.hasBorder;
                    borderThickness = window.borderThickness;
                    drawDashedLine = window.drawDashedLine;
                    dashes = window.dashes.ToArray<float>();

                    if (currentShape != null)
                    {
                        currentShape.ShapeType = Shape.ShapeTypes.Rectangle;
                        currentShape.LineStyle = window.drawDashedLine ? currentShape.LineStyle = Shape.LineStyles.Dashed : Shape.LineStyles.Solid;
                        currentShape.BorderThickness = borderThickness;
                        currentShape.Dashes = dashes;
                        currentShape.HasBorder = window.hasBorder;
                        currentShape.Coloring.HasFilling = hasFilling;
                        currentShape.Coloring.BorderColor = borderColor;
                        currentShape.Coloring.Fillings.Color = fillingColor;
                    }
                }
            }
        }
    }
}
