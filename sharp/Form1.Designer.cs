
namespace sharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Window Design

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ControlBox = false; /// Disabling a possibility to close and resize window 
            ///Если ControlBox не будет работать использовать функции ниже
            ///this.MinimizeBox = false;
            ///this.MaximizeBox = false; 
            this.ShowInTaskbar = false; /// Disabling visualisation in taskbar 
            this.ShowIcon = false; 
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; /// Enables Fullscreen
            this.BackgroundImage = System.Drawing.Image.FromFile(@"D:\workspace\wrapper\sharp\ngimg.png");
            ///this.TopMost = true;
            
        }
        #endregion
    }
}

