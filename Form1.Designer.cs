namespace ShaderMapGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiffuse = new System.Windows.Forms.Label();
            this.buttonOpenDiffuse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDispPreview = new System.Windows.Forms.Button();
            this.textDispBlur = new System.Windows.Forms.TextBox();
            this.textDispLevel = new System.Windows.Forms.TextBox();
            this.textDispSmooth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackDispBlur = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackDispLevel = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackDispSmooth = new System.Windows.Forms.TrackBar();
            this.checkDisp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNormPreview = new System.Windows.Forms.Button();
            this.checkNormInvertY = new System.Windows.Forms.CheckBox();
            this.checkNormInvertX = new System.Windows.Forms.CheckBox();
            this.textNormIntensity = new System.Windows.Forms.TextBox();
            this.textNormLevel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackNormIntensity = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackNormLevel = new System.Windows.Forms.TrackBar();
            this.checkNorm = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSpecPreview = new System.Windows.Forms.Button();
            this.textSpecContrast = new System.Windows.Forms.TextBox();
            this.textSpecBrightness = new System.Windows.Forms.TextBox();
            this.textSpecLevel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.trackSpecContrast = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trackSpecBrightness = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.trackSpecLevel = new System.Windows.Forms.TrackBar();
            this.checkSpec = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkCustom = new System.Windows.Forms.CheckBox();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.labelCustom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelWorkingExe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkPreview = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.openFileDiffuse = new System.Windows.Forms.OpenFileDialog();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonDiffpreview = new System.Windows.Forms.Button();
            this.openFileCustom = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDispBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDispLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDispSmooth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackNormIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNormLevel)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpecContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpecBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpecLevel)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diffuse Map :";
            // 
            // labelDiffuse
            // 
            this.labelDiffuse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDiffuse.Location = new System.Drawing.Point(88, 9);
            this.labelDiffuse.Name = "labelDiffuse";
            this.labelDiffuse.Size = new System.Drawing.Size(531, 20);
            this.labelDiffuse.TabIndex = 1;
            this.labelDiffuse.Text = "\\\\";
            this.labelDiffuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOpenDiffuse
            // 
            this.buttonOpenDiffuse.Location = new System.Drawing.Point(625, 9);
            this.buttonOpenDiffuse.Name = "buttonOpenDiffuse";
            this.buttonOpenDiffuse.Size = new System.Drawing.Size(39, 20);
            this.buttonOpenDiffuse.TabIndex = 2;
            this.buttonOpenDiffuse.Text = "...";
            this.buttonOpenDiffuse.UseVisualStyleBackColor = true;
            this.buttonOpenDiffuse.Click += new System.EventHandler(this.buttonOpenDiffuse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDispPreview);
            this.groupBox1.Controls.Add(this.textDispBlur);
            this.groupBox1.Controls.Add(this.textDispLevel);
            this.groupBox1.Controls.Add(this.textDispSmooth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.trackDispBlur);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackDispLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackDispSmooth);
            this.groupBox1.Controls.Add(this.checkDisp);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Displacement Map :";
            // 
            // buttonDispPreview
            // 
            this.buttonDispPreview.Location = new System.Drawing.Point(190, 117);
            this.buttonDispPreview.Name = "buttonDispPreview";
            this.buttonDispPreview.Size = new System.Drawing.Size(20, 20);
            this.buttonDispPreview.TabIndex = 10;
            this.buttonDispPreview.Text = "P";
            this.buttonDispPreview.UseVisualStyleBackColor = true;
            this.buttonDispPreview.Click += new System.EventHandler(this.buttonDispPreview_Click);
            // 
            // textDispBlur
            // 
            this.textDispBlur.Location = new System.Drawing.Point(164, 91);
            this.textDispBlur.Name = "textDispBlur";
            this.textDispBlur.Size = new System.Drawing.Size(46, 20);
            this.textDispBlur.TabIndex = 9;
            this.textDispBlur.Text = "100";
            this.textDispBlur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDispLevel
            // 
            this.textDispLevel.Location = new System.Drawing.Point(164, 67);
            this.textDispLevel.Name = "textDispLevel";
            this.textDispLevel.Size = new System.Drawing.Size(46, 20);
            this.textDispLevel.TabIndex = 8;
            this.textDispLevel.Text = "100";
            this.textDispLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDispSmooth
            // 
            this.textDispSmooth.Location = new System.Drawing.Point(164, 43);
            this.textDispSmooth.Name = "textDispSmooth";
            this.textDispSmooth.Size = new System.Drawing.Size(46, 20);
            this.textDispSmooth.TabIndex = 7;
            this.textDispSmooth.Text = "100";
            this.textDispSmooth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Post Blur :";
            // 
            // trackDispBlur
            // 
            this.trackDispBlur.Location = new System.Drawing.Point(57, 91);
            this.trackDispBlur.Maximum = 100;
            this.trackDispBlur.Name = "trackDispBlur";
            this.trackDispBlur.Size = new System.Drawing.Size(101, 42);
            this.trackDispBlur.TabIndex = 5;
            this.trackDispBlur.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackDispBlur.Scroll += new System.EventHandler(this.trackDispBlur_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Level :";
            // 
            // trackDispLevel
            // 
            this.trackDispLevel.Location = new System.Drawing.Point(57, 67);
            this.trackDispLevel.Maximum = 100;
            this.trackDispLevel.Minimum = -100;
            this.trackDispLevel.Name = "trackDispLevel";
            this.trackDispLevel.Size = new System.Drawing.Size(101, 42);
            this.trackDispLevel.TabIndex = 3;
            this.trackDispLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackDispLevel.Scroll += new System.EventHandler(this.trackDispLevel_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Smooth :";
            // 
            // trackDispSmooth
            // 
            this.trackDispSmooth.Location = new System.Drawing.Point(57, 43);
            this.trackDispSmooth.Maximum = 100;
            this.trackDispSmooth.Name = "trackDispSmooth";
            this.trackDispSmooth.Size = new System.Drawing.Size(101, 42);
            this.trackDispSmooth.TabIndex = 1;
            this.trackDispSmooth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackDispSmooth.Scroll += new System.EventHandler(this.trackDispSmooth_Scroll);
            // 
            // checkDisp
            // 
            this.checkDisp.AutoSize = true;
            this.checkDisp.Checked = true;
            this.checkDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisp.Location = new System.Drawing.Point(6, 19);
            this.checkDisp.Name = "checkDisp";
            this.checkDisp.Size = new System.Drawing.Size(59, 17);
            this.checkDisp.TabIndex = 0;
            this.checkDisp.Text = "Enable";
            this.checkDisp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNormPreview);
            this.groupBox2.Controls.Add(this.checkNormInvertY);
            this.groupBox2.Controls.Add(this.checkNormInvertX);
            this.groupBox2.Controls.Add(this.textNormIntensity);
            this.groupBox2.Controls.Add(this.textNormLevel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.trackNormIntensity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.trackNormLevel);
            this.groupBox2.Controls.Add(this.checkNorm);
            this.groupBox2.Location = new System.Drawing.Point(239, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normal Map :";
            // 
            // buttonNormPreview
            // 
            this.buttonNormPreview.Location = new System.Drawing.Point(190, 117);
            this.buttonNormPreview.Name = "buttonNormPreview";
            this.buttonNormPreview.Size = new System.Drawing.Size(20, 20);
            this.buttonNormPreview.TabIndex = 18;
            this.buttonNormPreview.Text = "P";
            this.buttonNormPreview.UseVisualStyleBackColor = true;
            this.buttonNormPreview.Click += new System.EventHandler(this.buttonNormPreview_Click);
            // 
            // checkNormInvertY
            // 
            this.checkNormInvertY.AutoSize = true;
            this.checkNormInvertY.Location = new System.Drawing.Point(110, 97);
            this.checkNormInvertY.Name = "checkNormInvertY";
            this.checkNormInvertY.Size = new System.Drawing.Size(63, 17);
            this.checkNormInvertY.TabIndex = 11;
            this.checkNormInvertY.Text = "Invert Y";
            this.checkNormInvertY.UseVisualStyleBackColor = true;
            // 
            // checkNormInvertX
            // 
            this.checkNormInvertX.AutoSize = true;
            this.checkNormInvertX.Location = new System.Drawing.Point(9, 97);
            this.checkNormInvertX.Name = "checkNormInvertX";
            this.checkNormInvertX.Size = new System.Drawing.Size(63, 17);
            this.checkNormInvertX.TabIndex = 10;
            this.checkNormInvertX.Text = "Invert X";
            this.checkNormInvertX.UseVisualStyleBackColor = true;
            // 
            // textNormIntensity
            // 
            this.textNormIntensity.Location = new System.Drawing.Point(164, 65);
            this.textNormIntensity.Name = "textNormIntensity";
            this.textNormIntensity.Size = new System.Drawing.Size(46, 20);
            this.textNormIntensity.TabIndex = 17;
            this.textNormIntensity.Text = "100";
            this.textNormIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNormLevel
            // 
            this.textNormLevel.Location = new System.Drawing.Point(164, 41);
            this.textNormLevel.Name = "textNormLevel";
            this.textNormLevel.Size = new System.Drawing.Size(46, 20);
            this.textNormLevel.TabIndex = 16;
            this.textNormLevel.Text = "100";
            this.textNormLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Intensity :";
            // 
            // trackNormIntensity
            // 
            this.trackNormIntensity.Location = new System.Drawing.Point(57, 65);
            this.trackNormIntensity.Maximum = 500;
            this.trackNormIntensity.Name = "trackNormIntensity";
            this.trackNormIntensity.Size = new System.Drawing.Size(101, 42);
            this.trackNormIntensity.TabIndex = 14;
            this.trackNormIntensity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackNormIntensity.Scroll += new System.EventHandler(this.trackNormIntensity_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Level :";
            // 
            // trackNormLevel
            // 
            this.trackNormLevel.Location = new System.Drawing.Point(57, 41);
            this.trackNormLevel.Maximum = 100;
            this.trackNormLevel.Minimum = -100;
            this.trackNormLevel.Name = "trackNormLevel";
            this.trackNormLevel.Size = new System.Drawing.Size(101, 42);
            this.trackNormLevel.TabIndex = 12;
            this.trackNormLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackNormLevel.Scroll += new System.EventHandler(this.trackNormLevel_Scroll);
            // 
            // checkNorm
            // 
            this.checkNorm.AutoSize = true;
            this.checkNorm.Checked = true;
            this.checkNorm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNorm.Location = new System.Drawing.Point(6, 19);
            this.checkNorm.Name = "checkNorm";
            this.checkNorm.Size = new System.Drawing.Size(59, 17);
            this.checkNorm.TabIndex = 0;
            this.checkNorm.Text = "Enable";
            this.checkNorm.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSpecPreview);
            this.groupBox4.Controls.Add(this.textSpecContrast);
            this.groupBox4.Controls.Add(this.textSpecBrightness);
            this.groupBox4.Controls.Add(this.textSpecLevel);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.trackSpecContrast);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.trackSpecBrightness);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.trackSpecLevel);
            this.groupBox4.Controls.Add(this.checkSpec);
            this.groupBox4.Location = new System.Drawing.Point(466, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 147);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specular Map :";
            // 
            // buttonSpecPreview
            // 
            this.buttonSpecPreview.Location = new System.Drawing.Point(192, 121);
            this.buttonSpecPreview.Name = "buttonSpecPreview";
            this.buttonSpecPreview.Size = new System.Drawing.Size(20, 20);
            this.buttonSpecPreview.TabIndex = 19;
            this.buttonSpecPreview.Text = "P";
            this.buttonSpecPreview.UseVisualStyleBackColor = true;
            this.buttonSpecPreview.Click += new System.EventHandler(this.buttonSpecPreview_Click);
            // 
            // textSpecContrast
            // 
            this.textSpecContrast.Location = new System.Drawing.Point(166, 92);
            this.textSpecContrast.Name = "textSpecContrast";
            this.textSpecContrast.Size = new System.Drawing.Size(46, 20);
            this.textSpecContrast.TabIndex = 18;
            this.textSpecContrast.Text = "100";
            this.textSpecContrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSpecBrightness
            // 
            this.textSpecBrightness.Location = new System.Drawing.Point(166, 68);
            this.textSpecBrightness.Name = "textSpecBrightness";
            this.textSpecBrightness.Size = new System.Drawing.Size(46, 20);
            this.textSpecBrightness.TabIndex = 17;
            this.textSpecBrightness.Text = "100";
            this.textSpecBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSpecLevel
            // 
            this.textSpecLevel.Location = new System.Drawing.Point(166, 44);
            this.textSpecLevel.Name = "textSpecLevel";
            this.textSpecLevel.Size = new System.Drawing.Size(46, 20);
            this.textSpecLevel.TabIndex = 16;
            this.textSpecLevel.Text = "100";
            this.textSpecLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Contrast :";
            // 
            // trackSpecContrast
            // 
            this.trackSpecContrast.Location = new System.Drawing.Point(59, 92);
            this.trackSpecContrast.Maximum = 100;
            this.trackSpecContrast.Name = "trackSpecContrast";
            this.trackSpecContrast.Size = new System.Drawing.Size(101, 42);
            this.trackSpecContrast.TabIndex = 14;
            this.trackSpecContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackSpecContrast.Scroll += new System.EventHandler(this.trackSpecContrast_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Brightness :";
            // 
            // trackSpecBrightness
            // 
            this.trackSpecBrightness.Location = new System.Drawing.Point(59, 68);
            this.trackSpecBrightness.Maximum = 100;
            this.trackSpecBrightness.Minimum = -100;
            this.trackSpecBrightness.Name = "trackSpecBrightness";
            this.trackSpecBrightness.Size = new System.Drawing.Size(101, 42);
            this.trackSpecBrightness.TabIndex = 12;
            this.trackSpecBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackSpecBrightness.Scroll += new System.EventHandler(this.trackSpecBrightness_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Level :";
            // 
            // trackSpecLevel
            // 
            this.trackSpecLevel.Location = new System.Drawing.Point(59, 44);
            this.trackSpecLevel.Maximum = 100;
            this.trackSpecLevel.Minimum = -100;
            this.trackSpecLevel.Name = "trackSpecLevel";
            this.trackSpecLevel.Size = new System.Drawing.Size(101, 42);
            this.trackSpecLevel.TabIndex = 10;
            this.trackSpecLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackSpecLevel.Scroll += new System.EventHandler(this.trackSpecLevel_Scroll);
            // 
            // checkSpec
            // 
            this.checkSpec.AutoSize = true;
            this.checkSpec.Checked = true;
            this.checkSpec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSpec.Location = new System.Drawing.Point(6, 19);
            this.checkSpec.Name = "checkSpec";
            this.checkSpec.Size = new System.Drawing.Size(59, 17);
            this.checkSpec.TabIndex = 0;
            this.checkSpec.Text = "Enable";
            this.checkSpec.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkCustom);
            this.groupBox5.Controls.Add(this.buttonCustom);
            this.groupBox5.Controls.Add(this.labelCustom);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.labelWorkingExe);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.checkPreview);
            this.groupBox5.Location = new System.Drawing.Point(239, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 119);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Options";
            // 
            // checkCustom
            // 
            this.checkCustom.AutoSize = true;
            this.checkCustom.Location = new System.Drawing.Point(128, 53);
            this.checkCustom.Name = "checkCustom";
            this.checkCustom.Size = new System.Drawing.Size(15, 14);
            this.checkCustom.TabIndex = 15;
            this.checkCustom.UseVisualStyleBackColor = true;
            this.checkCustom.CheckedChanged += new System.EventHandler(this.checkCustom_CheckedChanged);
            // 
            // buttonCustom
            // 
            this.buttonCustom.Enabled = false;
            this.buttonCustom.Location = new System.Drawing.Point(403, 49);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(39, 20);
            this.buttonCustom.TabIndex = 14;
            this.buttonCustom.Text = "...";
            this.buttonCustom.UseVisualStyleBackColor = true;
            this.buttonCustom.Click += new System.EventHandler(this.buttonCustom_Click);
            // 
            // labelCustom
            // 
            this.labelCustom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustom.Location = new System.Drawing.Point(149, 49);
            this.labelCustom.Name = "labelCustom";
            this.labelCustom.Size = new System.Drawing.Size(248, 20);
            this.labelCustom.TabIndex = 13;
            this.labelCustom.Text = "\\\\";
            this.labelCustom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Custom X file :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelWorkingExe
            // 
            this.labelWorkingExe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWorkingExe.Location = new System.Drawing.Point(149, 24);
            this.labelWorkingExe.Name = "labelWorkingExe";
            this.labelWorkingExe.Size = new System.Drawing.Size(248, 20);
            this.labelWorkingExe.TabIndex = 10;
            this.labelWorkingExe.Text = "C:\\Program Files\\ShaderMap CL 1.1.1";
            this.labelWorkingExe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Shader Map CL working dir :";
            // 
            // checkPreview
            // 
            this.checkPreview.AutoSize = true;
            this.checkPreview.Location = new System.Drawing.Point(9, 82);
            this.checkPreview.Name = "checkPreview";
            this.checkPreview.Size = new System.Drawing.Size(157, 17);
            this.checkPreview.TabIndex = 8;
            this.checkPreview.Text = "Show preview after process";
            this.checkPreview.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(531, 360);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(612, 360);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // openFileDiffuse
            // 
            this.openFileDiffuse.FileName = "openFileDiffuse";
            // 
            // picturePreview
            // 
            this.picturePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePreview.Location = new System.Drawing.Point(6, 19);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(209, 168);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 11;
            this.picturePreview.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picturePreview);
            this.groupBox6.Location = new System.Drawing.Point(12, 190);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(221, 193);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Map preview :";
            // 
            // buttonDiffpreview
            // 
            this.buttonDiffpreview.Location = new System.Drawing.Point(670, 9);
            this.buttonDiffpreview.Name = "buttonDiffpreview";
            this.buttonDiffpreview.Size = new System.Drawing.Size(20, 20);
            this.buttonDiffpreview.TabIndex = 13;
            this.buttonDiffpreview.Text = "P";
            this.buttonDiffpreview.UseVisualStyleBackColor = true;
            this.buttonDiffpreview.Click += new System.EventHandler(this.buttonDiffpreview_Click);
            // 
            // openFileCustom
            // 
            this.openFileCustom.FileName = "openFileCustom";
            this.openFileCustom.Filter = "X Files|*.x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 390);
            this.Controls.Add(this.buttonDiffpreview);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOpenDiffuse);
            this.Controls.Add(this.labelDiffuse);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShaderMap GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDispBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDispLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDispSmooth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackNormIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNormLevel)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpecContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpecBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpecLevel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiffuse;
        private System.Windows.Forms.Button buttonOpenDiffuse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkDisp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkNorm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkSpec;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelWorkingExe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkPreview;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.OpenFileDialog openFileDiffuse;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.Label labelCustom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackDispLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackDispSmooth;
        private System.Windows.Forms.CheckBox checkNormInvertY;
        private System.Windows.Forms.CheckBox checkNormInvertX;
        private System.Windows.Forms.TextBox textDispBlur;
        private System.Windows.Forms.TextBox textDispLevel;
        private System.Windows.Forms.TextBox textDispSmooth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackDispBlur;
        private System.Windows.Forms.CheckBox checkCustom;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonDispPreview;
        private System.Windows.Forms.Button buttonDiffpreview;
        private System.Windows.Forms.TextBox textNormIntensity;
        private System.Windows.Forms.TextBox textNormLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackNormIntensity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackNormLevel;
        private System.Windows.Forms.TextBox textSpecContrast;
        private System.Windows.Forms.TextBox textSpecBrightness;
        private System.Windows.Forms.TextBox textSpecLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackSpecContrast;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackSpecBrightness;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackSpecLevel;
        private System.Windows.Forms.Button buttonNormPreview;
        private System.Windows.Forms.Button buttonSpecPreview;
        private System.Windows.Forms.OpenFileDialog openFileCustom;
    }
}

