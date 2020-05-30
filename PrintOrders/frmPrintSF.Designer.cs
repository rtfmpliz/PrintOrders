namespace PrintOrders
{
    partial class frmPrintSF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintSF));
            this.maps1 = new Syncfusion.Windows.Forms.Maps.Maps();
            this.SuspendLayout();
            // 
            // maps1
            // 
            this.maps1.EnableZoomOnSelection = false;
            this.maps1.Layers = ((System.Collections.ObjectModel.ObservableCollection<Syncfusion.Windows.Forms.Maps.ShapeFileLayer>)(resources.GetObject("maps1.Layers")));
            this.maps1.Location = new System.Drawing.Point(156, 236);
            this.maps1.MapItemFont = null;
            this.maps1.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.Ellipse;
            this.maps1.Margin = new System.Windows.Forms.Padding(20);
            this.maps1.Name = "maps1";
            this.maps1.OnSelectionChanged = null;
            this.maps1.Size = new System.Drawing.Size(180, 90);
            this.maps1.TabIndex = 0;
            this.maps1.Text = "maps1";
            this.maps1.Click += new System.EventHandler(this.maps1_Click);
            // 
            // frmPrintSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maps1);
            this.Name = "frmPrintSF";
            this.Text = "frmPrintSF";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Maps.Maps maps1;
    }
}