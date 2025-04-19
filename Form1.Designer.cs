namespace PLC_Simulador_de_Tren_Tia_Portal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_createPLC = new System.Windows.Forms.Button();
            this.txtBox_PLCName = new System.Windows.Forms.TextBox();
            this.txtBox_PLCIPAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deletePLC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SubNet = new System.Windows.Forms.TextBox();
            this.groupBox_VirtualPLC = new System.Windows.Forms.GroupBox();
            this.btn_PowerOn = new System.Windows.Forms.Button();
            this.btn_PowerOff = new System.Windows.Forms.Button();
            this.btn_RebootPLC = new System.Windows.Forms.Button();
            this.combobox_virtual_PLCName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_STOP = new System.Windows.Forms.Button();
            this.btn_RUN = new System.Windows.Forms.Button();
            this.lb_currentOperatingState = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_ConnectionType = new System.Windows.Forms.Label();
            this.rb_local = new System.Windows.Forms.RadioButton();
            this.rb_tcpip = new System.Windows.Forms.RadioButton();
            this.tb_scaling = new System.Windows.Forms.TrackBar();
            this.txtBox_Scaling = new System.Windows.Forms.TextBox();
            this.btn_scalingSave = new System.Windows.Forms.Button();
            this.groupBox_VirtualPLC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_scaling)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createPLC
            // 
            this.btn_createPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createPLC.Location = new System.Drawing.Point(12, 50);
            this.btn_createPLC.Name = "btn_createPLC";
            this.btn_createPLC.Size = new System.Drawing.Size(109, 31);
            this.btn_createPLC.TabIndex = 0;
            this.btn_createPLC.Text = "Crear PLC";
            this.btn_createPLC.UseVisualStyleBackColor = true;
            this.btn_createPLC.Click += new System.EventHandler(this.btn_createPLC_Click);
            // 
            // txtBox_PLCName
            // 
            this.txtBox_PLCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PLCName.Location = new System.Drawing.Point(134, 54);
            this.txtBox_PLCName.Name = "txtBox_PLCName";
            this.txtBox_PLCName.Size = new System.Drawing.Size(137, 26);
            this.txtBox_PLCName.TabIndex = 1;
            // 
            // txtBox_PLCIPAdress
            // 
            this.txtBox_PLCIPAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PLCIPAdress.Location = new System.Drawing.Point(300, 54);
            this.txtBox_PLCIPAdress.Name = "txtBox_PLCIPAdress";
            this.txtBox_PLCIPAdress.Size = new System.Drawing.Size(137, 26);
            this.txtBox_PLCIPAdress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLC Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Address";
            // 
            // btn_deletePLC
            // 
            this.btn_deletePLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePLC.Location = new System.Drawing.Point(12, 118);
            this.btn_deletePLC.Name = "btn_deletePLC";
            this.btn_deletePLC.Size = new System.Drawing.Size(109, 31);
            this.btn_deletePLC.TabIndex = 5;
            this.btn_deletePLC.Text = "Elminimar PLC";
            this.btn_deletePLC.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Virtula PLC\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subnet-Mask";
            // 
            // textBox_SubNet
            // 
            this.textBox_SubNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SubNet.Location = new System.Drawing.Point(460, 55);
            this.textBox_SubNet.Name = "textBox_SubNet";
            this.textBox_SubNet.Size = new System.Drawing.Size(137, 26);
            this.textBox_SubNet.TabIndex = 8;
            // 
            // groupBox_VirtualPLC
            // 
            this.groupBox_VirtualPLC.Controls.Add(this.btn_scalingSave);
            this.groupBox_VirtualPLC.Controls.Add(this.txtBox_Scaling);
            this.groupBox_VirtualPLC.Controls.Add(this.tb_scaling);
            this.groupBox_VirtualPLC.Controls.Add(this.groupBox2);
            this.groupBox_VirtualPLC.Controls.Add(this.groupBox1);
            this.groupBox_VirtualPLC.Controls.Add(this.combobox_virtual_PLCName);
            this.groupBox_VirtualPLC.Controls.Add(this.btn_RebootPLC);
            this.groupBox_VirtualPLC.Controls.Add(this.btn_PowerOff);
            this.groupBox_VirtualPLC.Controls.Add(this.btn_PowerOn);
            this.groupBox_VirtualPLC.Controls.Add(this.txtBox_PLCName);
            this.groupBox_VirtualPLC.Controls.Add(this.label4);
            this.groupBox_VirtualPLC.Controls.Add(this.btn_createPLC);
            this.groupBox_VirtualPLC.Controls.Add(this.textBox_SubNet);
            this.groupBox_VirtualPLC.Controls.Add(this.txtBox_PLCIPAdress);
            this.groupBox_VirtualPLC.Controls.Add(this.label3);
            this.groupBox_VirtualPLC.Controls.Add(this.label1);
            this.groupBox_VirtualPLC.Controls.Add(this.label2);
            this.groupBox_VirtualPLC.Controls.Add(this.btn_deletePLC);
            this.groupBox_VirtualPLC.Location = new System.Drawing.Point(12, 12);
            this.groupBox_VirtualPLC.Name = "groupBox_VirtualPLC";
            this.groupBox_VirtualPLC.Size = new System.Drawing.Size(611, 454);
            this.groupBox_VirtualPLC.TabIndex = 10;
            this.groupBox_VirtualPLC.TabStop = false;
            this.groupBox_VirtualPLC.Text = "Virtual PLC";
            // 
            // btn_PowerOn
            // 
            this.btn_PowerOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PowerOn.Location = new System.Drawing.Point(12, 168);
            this.btn_PowerOn.Name = "btn_PowerOn";
            this.btn_PowerOn.Size = new System.Drawing.Size(109, 31);
            this.btn_PowerOn.TabIndex = 10;
            this.btn_PowerOn.Text = "Iniciar PLC";
            this.btn_PowerOn.UseVisualStyleBackColor = true;
            // 
            // btn_PowerOff
            // 
            this.btn_PowerOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PowerOff.Location = new System.Drawing.Point(12, 220);
            this.btn_PowerOff.Name = "btn_PowerOff";
            this.btn_PowerOff.Size = new System.Drawing.Size(109, 31);
            this.btn_PowerOff.TabIndex = 11;
            this.btn_PowerOff.Text = "Apagar PLC";
            this.btn_PowerOff.UseVisualStyleBackColor = true;
            // 
            // btn_RebootPLC
            // 
            this.btn_RebootPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RebootPLC.Location = new System.Drawing.Point(12, 269);
            this.btn_RebootPLC.Name = "btn_RebootPLC";
            this.btn_RebootPLC.Size = new System.Drawing.Size(109, 31);
            this.btn_RebootPLC.TabIndex = 12;
            this.btn_RebootPLC.Text = "Reiniciar PLC";
            this.btn_RebootPLC.UseVisualStyleBackColor = true;
            // 
            // combobox_virtual_PLCName
            // 
            this.combobox_virtual_PLCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_virtual_PLCName.FormattingEnabled = true;
            this.combobox_virtual_PLCName.Location = new System.Drawing.Point(138, 121);
            this.combobox_virtual_PLCName.Name = "combobox_virtual_PLCName";
            this.combobox_virtual_PLCName.Size = new System.Drawing.Size(299, 28);
            this.combobox_virtual_PLCName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_currentOperatingState);
            this.groupBox1.Controls.Add(this.btn_STOP);
            this.groupBox1.Controls.Add(this.btn_RUN);
            this.groupBox1.Location = new System.Drawing.Point(460, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 195);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de la Operacion";
            // 
            // btn_STOP
            // 
            this.btn_STOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_STOP.Location = new System.Drawing.Point(21, 122);
            this.btn_STOP.Name = "btn_STOP";
            this.btn_STOP.Size = new System.Drawing.Size(109, 31);
            this.btn_STOP.TabIndex = 13;
            this.btn_STOP.Text = "PARAR";
            this.btn_STOP.UseVisualStyleBackColor = true;
            // 
            // btn_RUN
            // 
            this.btn_RUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RUN.Location = new System.Drawing.Point(21, 70);
            this.btn_RUN.Name = "btn_RUN";
            this.btn_RUN.Size = new System.Drawing.Size(109, 31);
            this.btn_RUN.TabIndex = 12;
            this.btn_RUN.Text = "INICIAR";
            this.btn_RUN.UseVisualStyleBackColor = true;
            // 
            // lb_currentOperatingState
            // 
            this.lb_currentOperatingState.AutoSize = true;
            this.lb_currentOperatingState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_currentOperatingState.Location = new System.Drawing.Point(18, 27);
            this.lb_currentOperatingState.Name = "lb_currentOperatingState";
            this.lb_currentOperatingState.Size = new System.Drawing.Size(11, 16);
            this.lb_currentOperatingState.TabIndex = 14;
            this.lb_currentOperatingState.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_tcpip);
            this.groupBox2.Controls.Add(this.rb_local);
            this.groupBox2.Controls.Add(this.lb_ConnectionType);
            this.groupBox2.Location = new System.Drawing.Point(138, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 142);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de conexion";
            // 
            // lb_ConnectionType
            // 
            this.lb_ConnectionType.AutoSize = true;
            this.lb_ConnectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConnectionType.Location = new System.Drawing.Point(6, 24);
            this.lb_ConnectionType.Name = "lb_ConnectionType";
            this.lb_ConnectionType.Size = new System.Drawing.Size(11, 16);
            this.lb_ConnectionType.TabIndex = 15;
            this.lb_ConnectionType.Text = "-";
            // 
            // rb_local
            // 
            this.rb_local.AutoSize = true;
            this.rb_local.Location = new System.Drawing.Point(84, 30);
            this.rb_local.Name = "rb_local";
            this.rb_local.Size = new System.Drawing.Size(59, 17);
            this.rb_local.TabIndex = 16;
            this.rb_local.TabStop = true;
            this.rb_local.Text = "LOCAL";
            this.rb_local.UseVisualStyleBackColor = true;
            // 
            // rb_tcpip
            // 
            this.rb_tcpip.AutoSize = true;
            this.rb_tcpip.Location = new System.Drawing.Point(203, 31);
            this.rb_tcpip.Name = "rb_tcpip";
            this.rb_tcpip.Size = new System.Drawing.Size(61, 17);
            this.rb_tcpip.TabIndex = 17;
            this.rb_tcpip.TabStop = true;
            this.rb_tcpip.Text = "TCP/IP";
            this.rb_tcpip.UseVisualStyleBackColor = true;
            // 
            // tb_scaling
            // 
            this.tb_scaling.Location = new System.Drawing.Point(138, 338);
            this.tb_scaling.Name = "tb_scaling";
            this.tb_scaling.Size = new System.Drawing.Size(134, 45);
            this.tb_scaling.TabIndex = 16;
            // 
            // txtBox_Scaling
            // 
            this.txtBox_Scaling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Scaling.Location = new System.Drawing.Point(293, 338);
            this.txtBox_Scaling.Name = "txtBox_Scaling";
            this.txtBox_Scaling.Size = new System.Drawing.Size(137, 26);
            this.txtBox_Scaling.TabIndex = 17;
            // 
            // btn_scalingSave
            // 
            this.btn_scalingSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scalingSave.Location = new System.Drawing.Point(460, 333);
            this.btn_scalingSave.Name = "btn_scalingSave";
            this.btn_scalingSave.Size = new System.Drawing.Size(109, 31);
            this.btn_scalingSave.TabIndex = 18;
            this.btn_scalingSave.Text = "Guardar";
            this.btn_scalingSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 689);
            this.Controls.Add(this.groupBox_VirtualPLC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.groupBox_VirtualPLC.ResumeLayout(false);
            this.groupBox_VirtualPLC.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_scaling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createPLC;
        private System.Windows.Forms.TextBox txtBox_PLCName;
        private System.Windows.Forms.TextBox txtBox_PLCIPAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deletePLC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SubNet;
        private System.Windows.Forms.GroupBox groupBox_VirtualPLC;
        private System.Windows.Forms.Button btn_PowerOn;
        private System.Windows.Forms.Button btn_RebootPLC;
        private System.Windows.Forms.Button btn_PowerOff;
        private System.Windows.Forms.ComboBox combobox_virtual_PLCName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_STOP;
        private System.Windows.Forms.Button btn_RUN;
        private System.Windows.Forms.Label lb_currentOperatingState;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_ConnectionType;
        private System.Windows.Forms.RadioButton rb_tcpip;
        private System.Windows.Forms.RadioButton rb_local;
        private System.Windows.Forms.TrackBar tb_scaling;
        private System.Windows.Forms.TextBox txtBox_Scaling;
        private System.Windows.Forms.Button btn_scalingSave;
    }
}

