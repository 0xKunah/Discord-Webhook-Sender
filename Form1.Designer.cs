namespace DiscordRPC
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webhook_id = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.profilepic = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.isText = new System.Windows.Forms.RadioButton();
            this.isEmbed = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.color = new System.Windows.Forms.TextBox();
            this.atch = new System.Windows.Forms.TextBox();
            this.e_author = new System.Windows.Forms.TextBox();
            this.footer = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.thumb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webhook_id
            // 
            this.webhook_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.webhook_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webhook_id.ForeColor = System.Drawing.Color.White;
            this.webhook_id.Location = new System.Drawing.Point(12, 28);
            this.webhook_id.Name = "webhook_id";
            this.webhook_id.Size = new System.Drawing.Size(612, 20);
            this.webhook_id.TabIndex = 0;
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.author.ForeColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(12, 54);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(305, 20);
            this.author.TabIndex = 1;
            // 
            // profilepic
            // 
            this.profilepic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.profilepic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilepic.ForeColor = System.Drawing.Color.White;
            this.profilepic.Location = new System.Drawing.Point(323, 54);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(301, 20);
            this.profilepic.TabIndex = 2;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(53)))));
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(12, 395);
            this.reset.Margin = new System.Windows.Forms.Padding(0);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(209, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(415, 395);
            this.send.Margin = new System.Windows.Forms.Padding(0);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(209, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // isText
            // 
            this.isText.AutoSize = true;
            this.isText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isText.Location = new System.Drawing.Point(15, 112);
            this.isText.Name = "isText";
            this.isText.Size = new System.Drawing.Size(45, 17);
            this.isText.TabIndex = 6;
            this.isText.TabStop = true;
            this.isText.Text = "Text";
            this.isText.UseVisualStyleBackColor = true;
            this.isText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // isEmbed
            // 
            this.isEmbed.AutoSize = true;
            this.isEmbed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isEmbed.Location = new System.Drawing.Point(15, 245);
            this.isEmbed.Name = "isEmbed";
            this.isEmbed.Size = new System.Drawing.Size(57, 17);
            this.isEmbed.TabIndex = 7;
            this.isEmbed.TabStop = true;
            this.isEmbed.Text = "Embed";
            this.isEmbed.UseVisualStyleBackColor = true;
            this.isEmbed.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color.Enabled = false;
            this.color.ForeColor = System.Drawing.Color.White;
            this.color.Location = new System.Drawing.Point(484, 268);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(140, 20);
            this.color.TabIndex = 9;
            // 
            // atch
            // 
            this.atch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.atch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.atch.Enabled = false;
            this.atch.ForeColor = System.Drawing.Color.White;
            this.atch.Location = new System.Drawing.Point(12, 362);
            this.atch.Name = "atch";
            this.atch.Size = new System.Drawing.Size(612, 20);
            this.atch.TabIndex = 13;
            // 
            // e_author
            // 
            this.e_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.e_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.e_author.Enabled = false;
            this.e_author.ForeColor = System.Drawing.Color.White;
            this.e_author.Location = new System.Drawing.Point(12, 294);
            this.e_author.Name = "e_author";
            this.e_author.Size = new System.Drawing.Size(140, 20);
            this.e_author.TabIndex = 14;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footer.Enabled = false;
            this.footer.ForeColor = System.Drawing.Color.White;
            this.footer.Location = new System.Drawing.Point(158, 294);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(140, 20);
            this.footer.TabIndex = 15;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Enabled = false;
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 268);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(140, 20);
            this.title.TabIndex = 16;
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc.Enabled = false;
            this.desc.ForeColor = System.Drawing.Color.White;
            this.desc.Location = new System.Drawing.Point(158, 268);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(320, 20);
            this.desc.TabIndex = 17;
            // 
            // thumb
            // 
            this.thumb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.thumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumb.Enabled = false;
            this.thumb.ForeColor = System.Drawing.Color.White;
            this.thumb.Location = new System.Drawing.Point(304, 294);
            this.thumb.Name = "thumb";
            this.thumb.Size = new System.Drawing.Size(320, 20);
            this.thumb.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Attachment";
            // 
            // message
            // 
            this.message.AcceptsTab = true;
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.HideSelection = false;
            this.message.Location = new System.Drawing.Point(12, 135);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(612, 104);
            this.message.TabIndex = 23;
            // 
            // url
            // 
            this.url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.url.Enabled = false;
            this.url.ForeColor = System.Drawing.Color.White;
            this.url.Location = new System.Drawing.Point(12, 320);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(612, 20);
            this.url.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Global informations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Message type";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(638, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.url);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thumb);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.title);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.e_author);
            this.Controls.Add(this.atch);
            this.Controls.Add(this.color);
            this.Controls.Add(this.isEmbed);
            this.Controls.Add(this.isText);
            this.Controls.Add(this.send);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.profilepic);
            this.Controls.Add(this.author);
            this.Controls.Add(this.webhook_id);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Discord Webhook Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox webhook_id;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox profilepic;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RadioButton isText;
        private System.Windows.Forms.RadioButton isEmbed;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox atch;
        private System.Windows.Forms.TextBox e_author;
        private System.Windows.Forms.TextBox footer;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox thumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

