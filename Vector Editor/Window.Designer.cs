namespace Vector_Editor
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statePanel = new System.Windows.Forms.StatusBarPanel();
            this.canvasInformationPanel = new System.Windows.Forms.StatusBarPanel();
            this.drawingToolInformationPanel = new System.Windows.Forms.StatusBarPanel();
            this.elementInformationPanel = new System.Windows.Forms.StatusBarPanel();
            this.menu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.dimensionsMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.ellipseToolMenuItem = new System.Windows.Forms.MenuItem();
            this.lineToolMenuItem = new System.Windows.Forms.MenuItem();
            this.polygonToolMenuItem = new System.Windows.Forms.MenuItem();
            this.rectangleToolMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.selectToolMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.horizontalRulerContextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.clearAllMarkersContextMenuItem = new System.Windows.Forms.MenuItem();
            this.clearCurrentMarkerContextMenuItem = new System.Windows.Forms.MenuItem();
            this.verticalRulerContextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem36 = new System.Windows.Forms.MenuItem();
            this.clearAllVerticalRulerMarkersContextMenuItem = new System.Windows.Forms.MenuItem();
            this.clearCurrentVerticalRulerMarkerContextMenuItem = new System.Windows.Forms.MenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.selectToolToolbarItem = new System.Windows.Forms.ToolStripButton();
            this.rectangleToolToolbarItem = new System.Windows.Forms.ToolStripButton();
            this.lineToolToolbarItem = new System.Windows.Forms.ToolStripButton();
            this.polygonToolToolbarItem = new System.Windows.Forms.ToolStripButton();
            this.pencilToolToolbarItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.borderThicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensionsToolbarItem = new System.Windows.Forms.ToolStripButton();
            this.canvas = new Vector_Editor.Controls.ExtendedPanel();
            this.horizontalRuler = new Vector_Editor.Ruler();
            this.verticalRuler = new Vector_Editor.Ruler();
            ((System.ComponentModel.ISupportInitialize)(this.statePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasInformationPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingToolInformationPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementInformationPanel)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 595);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statePanel,
            this.canvasInformationPanel,
            this.drawingToolInformationPanel,
            this.elementInformationPanel});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(1108, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "State: Idle.";
            // 
            // statePanel
            // 
            this.statePanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statePanel.Name = "statePanel";
            this.statePanel.Text = "State: Idle.";
            this.statePanel.Width = 68;
            // 
            // canvasInformationPanel
            // 
            this.canvasInformationPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.canvasInformationPanel.Name = "canvasInformationPanel";
            this.canvasInformationPanel.Width = 10;
            // 
            // drawingToolInformationPanel
            // 
            this.drawingToolInformationPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.drawingToolInformationPanel.Name = "drawingToolInformationPanel";
            this.drawingToolInformationPanel.Width = 10;
            // 
            // elementInformationPanel
            // 
            this.elementInformationPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.elementInformationPanel.Name = "elementInformationPanel";
            this.elementInformationPanel.Width = 10;
            // 
            // menu
            // 
            this.menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8,
            this.menuItem9});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem21,
            this.menuItem22,
            this.menuItem23,
            this.menuItem24,
            this.menuItem25,
            this.menuItem26,
            this.menuItem27,
            this.menuItem28,
            this.menuItem29});
            this.menuItem2.Text = "Edit";
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 0;
            this.menuItem21.Text = "Undo";
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 1;
            this.menuItem22.Text = "Redo";
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 2;
            this.menuItem23.Text = "-";
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 3;
            this.menuItem24.Text = "Cut";
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 4;
            this.menuItem25.Text = "Copy";
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 5;
            this.menuItem26.Text = "Paste";
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 6;
            this.menuItem27.Text = "-";
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 7;
            this.menuItem28.Text = "Select All";
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 8;
            this.menuItem29.Text = "Delete";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem32});
            this.menuItem3.Text = "View";
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 0;
            this.menuItem32.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem33,
            this.menuItem34});
            this.menuItem32.Text = "Zoom";
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 0;
            this.menuItem33.Text = "In";
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 1;
            this.menuItem34.Text = "Out";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "Format";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11});
            this.menuItem5.Text = "Canvas";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Properties";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.dimensionsMenuItem,
            this.menuItem12,
            this.menuItem13});
            this.menuItem6.Text = "Element";
            // 
            // dimensionsMenuItem
            // 
            this.dimensionsMenuItem.Index = 0;
            this.dimensionsMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
            this.dimensionsMenuItem.Text = "Dimensions";
            this.dimensionsMenuItem.Click += new System.EventHandler(this.dimensionsMenuItem_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "-";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "Properties";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 6;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10,
            this.menuItem17,
            this.menuItem18,
            this.menuItem19,
            this.menuItem20});
            this.menuItem7.Text = "Tools";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ellipseToolMenuItem,
            this.lineToolMenuItem,
            this.polygonToolMenuItem,
            this.rectangleToolMenuItem,
            this.menuItem15,
            this.selectToolMenuItem});
            this.menuItem10.Text = "Drawing Tools";
            // 
            // ellipseToolMenuItem
            // 
            this.ellipseToolMenuItem.Index = 0;
            this.ellipseToolMenuItem.Text = "Ellipse";
            // 
            // lineToolMenuItem
            // 
            this.lineToolMenuItem.Index = 1;
            this.lineToolMenuItem.Text = "Line";
            // 
            // polygonToolMenuItem
            // 
            this.polygonToolMenuItem.Index = 2;
            this.polygonToolMenuItem.Text = "Polygon";
            // 
            // rectangleToolMenuItem
            // 
            this.rectangleToolMenuItem.Index = 3;
            this.rectangleToolMenuItem.Text = "Rectangle";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 4;
            this.menuItem15.Text = "-";
            // 
            // selectToolMenuItem
            // 
            this.selectToolMenuItem.Index = 5;
            this.selectToolMenuItem.Text = "Select";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 1;
            this.menuItem17.Text = "-";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 2;
            this.menuItem18.Text = "Color Picker";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 3;
            this.menuItem19.Text = "-";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 4;
            this.menuItem20.Text = "Shape Filler";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 7;
            this.menuItem8.Text = "Window";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 8;
            this.menuItem9.Text = "Help";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(137)))), ((int)(((byte)(233)))));
            this.linkLabel1.Location = new System.Drawing.Point(9, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(22, 18);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "PX";
            // 
            // horizontalRulerContextMenu
            // 
            this.horizontalRulerContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem35});
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 0;
            this.menuItem35.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.clearAllMarkersContextMenuItem,
            this.clearCurrentMarkerContextMenuItem});
            this.menuItem35.Text = "Clear Marker(s)";
            // 
            // clearAllMarkersContextMenuItem
            // 
            this.clearAllMarkersContextMenuItem.Index = 0;
            this.clearAllMarkersContextMenuItem.Text = "All";
            this.clearAllMarkersContextMenuItem.Click += new System.EventHandler(this.clearAllMarkersContextMenuItem_Click);
            // 
            // clearCurrentMarkerContextMenuItem
            // 
            this.clearCurrentMarkerContextMenuItem.Index = 1;
            this.clearCurrentMarkerContextMenuItem.Text = "Current";
            this.clearCurrentMarkerContextMenuItem.Click += new System.EventHandler(this.clearCurrentMarkerContextMenuItem_Click);
            // 
            // verticalRulerContextMenu
            // 
            this.verticalRulerContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem36});
            // 
            // menuItem36
            // 
            this.menuItem36.Index = 0;
            this.menuItem36.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.clearAllVerticalRulerMarkersContextMenuItem,
            this.clearCurrentVerticalRulerMarkerContextMenuItem});
            this.menuItem36.Text = "Clear Marker(s)";
            // 
            // clearAllVerticalRulerMarkersContextMenuItem
            // 
            this.clearAllVerticalRulerMarkersContextMenuItem.Index = 0;
            this.clearAllVerticalRulerMarkersContextMenuItem.Text = "All";
            this.clearAllVerticalRulerMarkersContextMenuItem.Click += new System.EventHandler(this.clearAllVerticalRulerMarkersContextMenuItem_Click);
            // 
            // clearCurrentVerticalRulerMarkerContextMenuItem
            // 
            this.clearCurrentVerticalRulerMarkerContextMenuItem.Index = 1;
            this.clearCurrentVerticalRulerMarkerContextMenuItem.Text = "Current";
            this.clearCurrentVerticalRulerMarkerContextMenuItem.Click += new System.EventHandler(this.clearCurrentVerticalRulerMarkerContextMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.selectToolToolbarItem,
            this.rectangleToolToolbarItem,
            this.lineToolToolbarItem,
            this.polygonToolToolbarItem,
            this.pencilToolToolbarItem,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripButton9,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.dimensionsToolbarItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1108, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel1.Text = "File:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "New Design";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Open Design";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel2.Text = "Drawing Tools:";
            // 
            // selectToolToolbarItem
            // 
            this.selectToolToolbarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectToolToolbarItem.Image = ((System.Drawing.Image)(resources.GetObject("selectToolToolbarItem.Image")));
            this.selectToolToolbarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectToolToolbarItem.Name = "selectToolToolbarItem";
            this.selectToolToolbarItem.Size = new System.Drawing.Size(23, 22);
            this.selectToolToolbarItem.Text = "Select Tool";
            this.selectToolToolbarItem.Click += new System.EventHandler(this.selectToolToolbarItem_Click);
            // 
            // rectangleToolToolbarItem
            // 
            this.rectangleToolToolbarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleToolToolbarItem.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolToolbarItem.Image")));
            this.rectangleToolToolbarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleToolToolbarItem.Name = "rectangleToolToolbarItem";
            this.rectangleToolToolbarItem.Size = new System.Drawing.Size(23, 22);
            this.rectangleToolToolbarItem.Text = "Rectangle Tool";
            this.rectangleToolToolbarItem.Click += new System.EventHandler(this.rectangleToolToolbarItem_Click);
            // 
            // lineToolToolbarItem
            // 
            this.lineToolToolbarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolToolbarItem.Image = ((System.Drawing.Image)(resources.GetObject("lineToolToolbarItem.Image")));
            this.lineToolToolbarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolToolbarItem.Name = "lineToolToolbarItem";
            this.lineToolToolbarItem.Size = new System.Drawing.Size(23, 22);
            this.lineToolToolbarItem.Text = "Line Tool";
            this.lineToolToolbarItem.Click += new System.EventHandler(this.lineToolToolbarItem_Click);
            // 
            // polygonToolToolbarItem
            // 
            this.polygonToolToolbarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.polygonToolToolbarItem.Image = ((System.Drawing.Image)(resources.GetObject("polygonToolToolbarItem.Image")));
            this.polygonToolToolbarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polygonToolToolbarItem.Name = "polygonToolToolbarItem";
            this.polygonToolToolbarItem.Size = new System.Drawing.Size(23, 22);
            this.polygonToolToolbarItem.Text = "Polygon Tool";
            this.polygonToolToolbarItem.Click += new System.EventHandler(this.polygonToolToolbarItem_Click);
            // 
            // pencilToolToolbarItem
            // 
            this.pencilToolToolbarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pencilToolToolbarItem.Image = ((System.Drawing.Image)(resources.GetObject("pencilToolToolbarItem.Image")));
            this.pencilToolToolbarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencilToolToolbarItem.Name = "pencilToolToolbarItem";
            this.pencilToolToolbarItem.Size = new System.Drawing.Size(23, 22);
            this.pencilToolToolbarItem.Text = "Pencil Tool";
            this.pencilToolToolbarItem.Click += new System.EventHandler(this.pencilToolToolbarItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel3.Text = "Element Properties:";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borderThicknessToolStripMenuItem,
            this.borderColorToolStripMenuItem,
            this.borderStyleToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(111, 22);
            this.toolStripDropDownButton1.Text = "Border Properties";
            // 
            // borderThicknessToolStripMenuItem
            // 
            this.borderThicknessToolStripMenuItem.Name = "borderThicknessToolStripMenuItem";
            this.borderThicknessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borderThicknessToolStripMenuItem.Text = "Border Thickness";
            this.borderThicknessToolStripMenuItem.Click += new System.EventHandler(this.borderThicknessToolStripMenuItem_Click);
            // 
            // borderColorToolStripMenuItem
            // 
            this.borderColorToolStripMenuItem.Name = "borderColorToolStripMenuItem";
            this.borderColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borderColorToolStripMenuItem.Text = "Border Color";
            this.borderColorToolStripMenuItem.Click += new System.EventHandler(this.borderColorToolStripMenuItem_Click);
            // 
            // borderStyleToolStripMenuItem
            // 
            this.borderStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashedToolStripMenuItem});
            this.borderStyleToolStripMenuItem.Name = "borderStyleToolStripMenuItem";
            this.borderStyleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borderStyleToolStripMenuItem.Text = "Border Style";
            // 
            // dashedToolStripMenuItem
            // 
            this.dashedToolStripMenuItem.Name = "dashedToolStripMenuItem";
            this.dashedToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.dashedToolStripMenuItem.Text = "Dashed";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(108, 22);
            this.toolStripDropDownButton2.Text = "Filling Properties";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // dimensionsToolbarItem
            // 
            this.dimensionsToolbarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dimensionsToolbarItem.Image = ((System.Drawing.Image)(resources.GetObject("dimensionsToolbarItem.Image")));
            this.dimensionsToolbarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dimensionsToolbarItem.Name = "dimensionsToolbarItem";
            this.dimensionsToolbarItem.Size = new System.Drawing.Size(23, 22);
            this.dimensionsToolbarItem.Text = "Dimensions";
            this.dimensionsToolbarItem.Click += new System.EventHandler(this.dimensionsToolbarItem_Click);
            // 
            // canvas
            // 
            this.canvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(47, 63);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1049, 520);
            this.canvas.TabIndex = 3;
            this.canvas.Text = "extendedPanel1";
            this.canvas.SizeChanged += new System.EventHandler(this.canvas_SizeChanged);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canvas_KeyPress);
            this.canvas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.canvas_KeyUp);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            this.canvas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.canvas_PreviewKeyDown);
            // 
            // horizontalRuler
            // 
            this.horizontalRuler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalRuler.Direction = Vector_Editor.Ruler.Directions.Horizontal;
            this.horizontalRuler.Font = new System.Drawing.Font("Saira", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalRuler.IsDragging = false;
            this.horizontalRuler.Location = new System.Drawing.Point(47, 28);
            this.horizontalRuler.Marker = Vector_Editor.Ruler.Markers.All;
            this.horizontalRuler.Name = "horizontalRuler";
            this.horizontalRuler.RequestDrawing = false;
            this.horizontalRuler.Size = new System.Drawing.Size(1049, 29);
            this.horizontalRuler.TabIndex = 2;
            this.horizontalRuler.Text = "ruler2";
            // 
            // verticalRuler
            // 
            this.verticalRuler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verticalRuler.Direction = Vector_Editor.Ruler.Directions.Vertical;
            this.verticalRuler.Font = new System.Drawing.Font("Saira", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalRuler.IsDragging = false;
            this.verticalRuler.Location = new System.Drawing.Point(12, 63);
            this.verticalRuler.Marker = Vector_Editor.Ruler.Markers.All;
            this.verticalRuler.Name = "verticalRuler";
            this.verticalRuler.RequestDrawing = false;
            this.verticalRuler.Size = new System.Drawing.Size(29, 520);
            this.verticalRuler.TabIndex = 1;
            this.verticalRuler.Text = "ruler1";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1108, 617);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.horizontalRuler);
            this.Controls.Add(this.verticalRuler);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Saira", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu = this.menu;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vector Editor";
            this.Shown += new System.EventHandler(this.Window_Shown);
            this.SizeChanged += new System.EventHandler(this.Window_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.statePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasInformationPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingToolInformationPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementInformationPanel)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel statePanel;
        private System.Windows.Forms.StatusBarPanel canvasInformationPanel;
        private System.Windows.Forms.StatusBarPanel drawingToolInformationPanel;
        private System.Windows.Forms.StatusBarPanel elementInformationPanel;
        private System.Windows.Forms.MainMenu menu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem ellipseToolMenuItem;
        private System.Windows.Forms.MenuItem lineToolMenuItem;
        private System.Windows.Forms.MenuItem polygonToolMenuItem;
        private System.Windows.Forms.MenuItem rectangleToolMenuItem;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem selectToolMenuItem;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem menuItem21;
        private System.Windows.Forms.MenuItem menuItem22;
        private System.Windows.Forms.MenuItem menuItem23;
        private System.Windows.Forms.MenuItem menuItem24;
        private System.Windows.Forms.MenuItem menuItem25;
        private System.Windows.Forms.MenuItem menuItem26;
        private System.Windows.Forms.MenuItem menuItem27;
        private System.Windows.Forms.MenuItem menuItem28;
        private System.Windows.Forms.MenuItem menuItem29;
        private Ruler verticalRuler;
        private Ruler horizontalRuler;
        private Controls.ExtendedPanel canvas;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuItem menuItem32;
        private System.Windows.Forms.MenuItem menuItem33;
        private System.Windows.Forms.MenuItem menuItem34;
        private System.Windows.Forms.ContextMenu horizontalRulerContextMenu;
        private System.Windows.Forms.MenuItem menuItem35;
        private System.Windows.Forms.MenuItem clearAllMarkersContextMenuItem;
        private System.Windows.Forms.MenuItem clearCurrentMarkerContextMenuItem;
        private System.Windows.Forms.ContextMenu verticalRulerContextMenu;
        private System.Windows.Forms.MenuItem menuItem36;
        private System.Windows.Forms.MenuItem clearAllVerticalRulerMarkersContextMenuItem;
        private System.Windows.Forms.MenuItem clearCurrentVerticalRulerMarkerContextMenuItem;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton selectToolToolbarItem;
        private System.Windows.Forms.ToolStripButton rectangleToolToolbarItem;
        private System.Windows.Forms.ToolStripButton lineToolToolbarItem;
        private System.Windows.Forms.ToolStripButton polygonToolToolbarItem;
        private System.Windows.Forms.ToolStripButton pencilToolToolbarItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem borderThicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashedToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripButton dimensionsToolbarItem;
        private System.Windows.Forms.MenuItem dimensionsMenuItem;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    }
}

