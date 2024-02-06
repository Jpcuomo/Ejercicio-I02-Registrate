namespace Forms
{
    partial class FormRegistro
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBoxUsuario = new GroupBox();
            numEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            lblEdad = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            gBoxPais = new GroupBox();
            lBoxPaises = new ListBox();
            gBoxGenero = new GroupBox();
            rBtnNoBinario = new RadioButton();
            rBtnFemenino = new RadioButton();
            rBtnMasculino = new RadioButton();
            gBoxCursos = new GroupBox();
            cBoxJavaScript = new CheckBox();
            cBoxCmas = new CheckBox();
            cBoxC = new CheckBox();
            btnIngresar = new Button();
            gBoxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            gBoxPais.SuspendLayout();
            gBoxGenero.SuspendLayout();
            gBoxCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxUsuario
            // 
            gBoxUsuario.Controls.Add(numEdad);
            gBoxUsuario.Controls.Add(txtDireccion);
            gBoxUsuario.Controls.Add(lblEdad);
            gBoxUsuario.Controls.Add(lblDireccion);
            gBoxUsuario.Controls.Add(lblNombre);
            gBoxUsuario.Controls.Add(txtNombre);
            gBoxUsuario.Location = new Point(12, 12);
            gBoxUsuario.Name = "gBoxUsuario";
            gBoxUsuario.Size = new Size(251, 178);
            gBoxUsuario.TabIndex = 0;
            gBoxUsuario.TabStop = false;
            gBoxUsuario.Text = "Detalles de usuarios";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(89, 130);
            numEdad.Maximum = new decimal(new int[] { 110, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(143, 27);
            numEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(89, 83);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(143, 27);
            txtDireccion.TabIndex = 4;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(11, 132);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(11, 83);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(11, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 27);
            txtNombre.TabIndex = 0;
            // 
            // gBoxPais
            // 
            gBoxPais.Controls.Add(lBoxPaises);
            gBoxPais.Location = new Point(12, 196);
            gBoxPais.Name = "gBoxPais";
            gBoxPais.Size = new Size(251, 141);
            gBoxPais.TabIndex = 1;
            gBoxPais.TabStop = false;
            gBoxPais.Text = "País";
            // 
            // lBoxPaises
            // 
            lBoxPaises.FormattingEnabled = true;
            lBoxPaises.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lBoxPaises.Location = new Point(6, 26);
            lBoxPaises.Name = "lBoxPaises";
            lBoxPaises.Size = new Size(239, 104);
            lBoxPaises.TabIndex = 0;
            // 
            // gBoxGenero
            // 
            gBoxGenero.Controls.Add(rBtnNoBinario);
            gBoxGenero.Controls.Add(rBtnFemenino);
            gBoxGenero.Controls.Add(rBtnMasculino);
            gBoxGenero.Location = new Point(279, 12);
            gBoxGenero.Name = "gBoxGenero";
            gBoxGenero.Size = new Size(149, 135);
            gBoxGenero.TabIndex = 2;
            gBoxGenero.TabStop = false;
            gBoxGenero.Text = "Género";
            // 
            // rBtnNoBinario
            // 
            rBtnNoBinario.AutoSize = true;
            rBtnNoBinario.Location = new Point(16, 95);
            rBtnNoBinario.Name = "rBtnNoBinario";
            rBtnNoBinario.Size = new Size(101, 24);
            rBtnNoBinario.TabIndex = 2;
            rBtnNoBinario.Text = "No binario";
            rBtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // rBtnFemenino
            // 
            rBtnFemenino.AutoSize = true;
            rBtnFemenino.Location = new Point(16, 64);
            rBtnFemenino.Name = "rBtnFemenino";
            rBtnFemenino.Size = new Size(95, 24);
            rBtnFemenino.TabIndex = 1;
            rBtnFemenino.Text = "Femenino";
            rBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rBtnMasculino
            // 
            rBtnMasculino.AutoSize = true;
            rBtnMasculino.Checked = true;
            rBtnMasculino.Location = new Point(16, 34);
            rBtnMasculino.Name = "rBtnMasculino";
            rBtnMasculino.Size = new Size(97, 24);
            rBtnMasculino.TabIndex = 0;
            rBtnMasculino.TabStop = true;
            rBtnMasculino.Text = "Masculino";
            rBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // gBoxCursos
            // 
            gBoxCursos.Controls.Add(cBoxJavaScript);
            gBoxCursos.Controls.Add(cBoxCmas);
            gBoxCursos.Controls.Add(cBoxC);
            gBoxCursos.Location = new Point(279, 163);
            gBoxCursos.Name = "gBoxCursos";
            gBoxCursos.Size = new Size(149, 124);
            gBoxCursos.TabIndex = 3;
            gBoxCursos.TabStop = false;
            gBoxCursos.Text = "Cursos";
            // 
            // cBoxJavaScript
            // 
            cBoxJavaScript.AutoSize = true;
            cBoxJavaScript.Location = new Point(16, 93);
            cBoxJavaScript.Name = "cBoxJavaScript";
            cBoxJavaScript.Size = new Size(97, 24);
            cBoxJavaScript.TabIndex = 2;
            cBoxJavaScript.Text = "JavaScript";
            cBoxJavaScript.UseVisualStyleBackColor = true;
            // 
            // cBoxCmas
            // 
            cBoxCmas.AutoSize = true;
            cBoxCmas.Location = new Point(16, 63);
            cBoxCmas.Name = "cBoxCmas";
            cBoxCmas.Size = new Size(60, 24);
            cBoxCmas.TabIndex = 1;
            cBoxCmas.Text = "C++";
            cBoxCmas.UseVisualStyleBackColor = true;
            // 
            // cBoxC
            // 
            cBoxC.AutoSize = true;
            cBoxC.Location = new Point(16, 33);
            cBoxC.Name = "cBoxC";
            cBoxC.Size = new Size(49, 24);
            cBoxC.TabIndex = 0;
            cBoxC.Text = "C#";
            cBoxC.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(295, 297);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(117, 29);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 350);
            Controls.Add(btnIngresar);
            Controls.Add(gBoxCursos);
            Controls.Add(gBoxGenero);
            Controls.Add(gBoxPais);
            Controls.Add(gBoxUsuario);
            Name = "FormRegistro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            gBoxUsuario.ResumeLayout(false);
            gBoxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            gBoxPais.ResumeLayout(false);
            gBoxGenero.ResumeLayout(false);
            gBoxGenero.PerformLayout();
            gBoxCursos.ResumeLayout(false);
            gBoxCursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxUsuario;
        private Label lblNombre;
        private TextBox txtNombre;
        private NumericUpDown numEdad;
        private TextBox txtDireccion;
        private Label lblEdad;
        private Label lblDireccion;
        private GroupBox gBoxPais;
        private ListBox lBoxPaises;
        private GroupBox gBoxGenero;
        private RadioButton rBtnMasculino;
        private RadioButton rBtnNoBinario;
        private RadioButton rBtnFemenino;
        private GroupBox gBoxCursos;
        private CheckBox cBoxJavaScript;
        private CheckBox cBoxCmas;
        private CheckBox cBoxC;
        private Button btnIngresar;
    }
}
