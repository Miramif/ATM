namespace ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openCardDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabTransfer1 = new System.Windows.Forms.TabPage();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.textTAmount = new System.Windows.Forms.TextBox();
            this.labelTAmount = new System.Windows.Forms.Label();
            this.labelTCard = new System.Windows.Forms.Label();
            this.maskedTCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.buttonToMenuT1 = new System.Windows.Forms.Button();
            this.buttonExitT1 = new System.Windows.Forms.Button();
            this.buttonNextT1 = new System.Windows.Forms.Button();
            this.labelTransfer1 = new System.Windows.Forms.Label();
            this.tabWithdraw2 = new System.Windows.Forms.TabPage();
            this.panelWithdraw2 = new System.Windows.Forms.Panel();
            this.buttonToMenuW2 = new System.Windows.Forms.Button();
            this.buttonExitW2 = new System.Windows.Forms.Button();
            this.buttonWithdrawConfirm = new System.Windows.Forms.Button();
            this.labelWithdraw2 = new System.Windows.Forms.Label();
            this.tabWithdraw1 = new System.Windows.Forms.TabPage();
            this.panelWithdraw = new System.Windows.Forms.Panel();
            this.buttonToMenuW1 = new System.Windows.Forms.Button();
            this.textWithdraw = new System.Windows.Forms.TextBox();
            this.buttonExitW1 = new System.Windows.Forms.Button();
            this.buttonWithdrawNext = new System.Windows.Forms.Button();
            this.labelWithdraw1 = new System.Windows.Forms.Label();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.panelBalance = new System.Windows.Forms.Panel();
            this.buttonExitB = new System.Windows.Forms.Button();
            this.buttonToMenuB = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.tabMainMenu = new System.Windows.Forms.TabPage();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.tabPin = new System.Windows.Forms.TabPage();
            this.panelPin = new System.Windows.Forms.Panel();
            this.ButtonEnterPin = new System.Windows.Forms.Button();
            this.MaskedPinTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.tabLanguage = new System.Windows.Forms.TabPage();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.ChangeLangButEng = new System.Windows.Forms.Button();
            this.ChangeLangButUkr = new System.Windows.Forms.Button();
            this.labelLang = new System.Windows.Forms.Label();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.buttonInsertCard = new System.Windows.Forms.Button();
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.TabFrames1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.buttonExitS = new System.Windows.Forms.Button();
            this.buttonChangePin = new System.Windows.Forms.Button();
            this.buttonToMenuS = new System.Windows.Forms.Button();
            this.tabChangePin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedNewPin = new System.Windows.Forms.MaskedTextBox();
            this.LabelNewPin = new System.Windows.Forms.Label();
            this.labelOldPin = new System.Windows.Forms.Label();
            this.maskedOldPin = new System.Windows.Forms.MaskedTextBox();
            this.buttonToMenuSC = new System.Windows.Forms.Button();
            this.ButtonExitSC = new System.Windows.Forms.Button();
            this.buttonNextSC = new System.Windows.Forms.Button();
            this.labelChangePin = new System.Windows.Forms.Label();
            this.tabTransfer1.SuspendLayout();
            this.panelTransfer.SuspendLayout();
            this.tabWithdraw2.SuspendLayout();
            this.panelWithdraw2.SuspendLayout();
            this.tabWithdraw1.SuspendLayout();
            this.panelWithdraw.SuspendLayout();
            this.tabBalance.SuspendLayout();
            this.panelBalance.SuspendLayout();
            this.tabMainMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tabPin.SuspendLayout();
            this.panelPin.SuspendLayout();
            this.tabLanguage.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.TabFrames1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.tabChangePin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openCardDialog1
            // 
            this.openCardDialog1.AddExtension = false;
            this.openCardDialog1.Filter = "Cards files |*.crd";
            // 
            // tabTransfer1
            // 
            this.tabTransfer1.Controls.Add(this.panelTransfer);
            this.tabTransfer1.Location = new System.Drawing.Point(4, 25);
            this.tabTransfer1.Name = "tabTransfer1";
            this.tabTransfer1.Size = new System.Drawing.Size(569, 428);
            this.tabTransfer1.TabIndex = 7;
            this.tabTransfer1.Text = "Transfer1";
            this.tabTransfer1.UseVisualStyleBackColor = true;
            // 
            // panelTransfer
            // 
            this.panelTransfer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTransfer.Controls.Add(this.textTAmount);
            this.panelTransfer.Controls.Add(this.labelTAmount);
            this.panelTransfer.Controls.Add(this.labelTCard);
            this.panelTransfer.Controls.Add(this.maskedTCardNumber);
            this.panelTransfer.Controls.Add(this.buttonToMenuT1);
            this.panelTransfer.Controls.Add(this.buttonExitT1);
            this.panelTransfer.Controls.Add(this.buttonNextT1);
            this.panelTransfer.Controls.Add(this.labelTransfer1);
            this.panelTransfer.Location = new System.Drawing.Point(81, 86);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(407, 263);
            this.panelTransfer.TabIndex = 6;
            // 
            // textTAmount
            // 
            this.textTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTAmount.Location = new System.Drawing.Point(144, 142);
            this.textTAmount.Name = "textTAmount";
            this.textTAmount.Size = new System.Drawing.Size(245, 26);
            this.textTAmount.TabIndex = 12;
            this.textTAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTAmount_KeyPress);
            // 
            // labelTAmount
            // 
            this.labelTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTAmount.Location = new System.Drawing.Point(16, 141);
            this.labelTAmount.Name = "labelTAmount";
            this.labelTAmount.Size = new System.Drawing.Size(121, 26);
            this.labelTAmount.TabIndex = 11;
            // 
            // labelTCard
            // 
            this.labelTCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTCard.Location = new System.Drawing.Point(16, 109);
            this.labelTCard.Name = "labelTCard";
            this.labelTCard.Size = new System.Drawing.Size(120, 26);
            this.labelTCard.TabIndex = 10;
            // 
            // maskedTCardNumber
            // 
            this.maskedTCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTCardNumber.HidePromptOnLeave = true;
            this.maskedTCardNumber.HideSelection = false;
            this.maskedTCardNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTCardNumber.Location = new System.Drawing.Point(143, 109);
            this.maskedTCardNumber.Mask = "1414000000000000";
            this.maskedTCardNumber.Name = "maskedTCardNumber";
            this.maskedTCardNumber.PromptChar = '-';
            this.maskedTCardNumber.Size = new System.Drawing.Size(246, 26);
            this.maskedTCardNumber.TabIndex = 8;
            this.maskedTCardNumber.Enter += new System.EventHandler(this.MaskedTCardNumber_Enter);
            // 
            // buttonToMenuT1
            // 
            this.buttonToMenuT1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonToMenuT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMenuT1.Location = new System.Drawing.Point(269, 191);
            this.buttonToMenuT1.Name = "buttonToMenuT1";
            this.buttonToMenuT1.Size = new System.Drawing.Size(120, 59);
            this.buttonToMenuT1.TabIndex = 7;
            this.buttonToMenuT1.UseVisualStyleBackColor = false;
            this.buttonToMenuT1.Click += new System.EventHandler(this.ButtonToMenuT1_Click);
            // 
            // buttonExitT1
            // 
            this.buttonExitT1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExitT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitT1.Location = new System.Drawing.Point(16, 191);
            this.buttonExitT1.Name = "buttonExitT1";
            this.buttonExitT1.Size = new System.Drawing.Size(120, 59);
            this.buttonExitT1.TabIndex = 5;
            this.buttonExitT1.UseVisualStyleBackColor = false;
            this.buttonExitT1.Click += new System.EventHandler(this.ButtonExitT1_Click);
            // 
            // buttonNextT1
            // 
            this.buttonNextT1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNextT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextT1.Location = new System.Drawing.Point(143, 191);
            this.buttonNextT1.Name = "buttonNextT1";
            this.buttonNextT1.Size = new System.Drawing.Size(120, 59);
            this.buttonNextT1.TabIndex = 1;
            this.buttonNextT1.UseVisualStyleBackColor = false;
            this.buttonNextT1.Click += new System.EventHandler(this.ButtonNextT1_Click);
            // 
            // labelTransfer1
            // 
            this.labelTransfer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTransfer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransfer1.Location = new System.Drawing.Point(68, 14);
            this.labelTransfer1.Name = "labelTransfer1";
            this.labelTransfer1.Size = new System.Drawing.Size(276, 79);
            this.labelTransfer1.TabIndex = 0;
            this.labelTransfer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabWithdraw2
            // 
            this.tabWithdraw2.Controls.Add(this.panelWithdraw2);
            this.tabWithdraw2.Location = new System.Drawing.Point(4, 25);
            this.tabWithdraw2.Name = "tabWithdraw2";
            this.tabWithdraw2.Size = new System.Drawing.Size(569, 428);
            this.tabWithdraw2.TabIndex = 6;
            this.tabWithdraw2.Text = "Withdraw2";
            this.tabWithdraw2.UseVisualStyleBackColor = true;
            // 
            // panelWithdraw2
            // 
            this.panelWithdraw2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWithdraw2.Controls.Add(this.buttonToMenuW2);
            this.panelWithdraw2.Controls.Add(this.buttonExitW2);
            this.panelWithdraw2.Controls.Add(this.buttonWithdrawConfirm);
            this.panelWithdraw2.Controls.Add(this.labelWithdraw2);
            this.panelWithdraw2.Location = new System.Drawing.Point(81, 86);
            this.panelWithdraw2.Name = "panelWithdraw2";
            this.panelWithdraw2.Size = new System.Drawing.Size(407, 263);
            this.panelWithdraw2.TabIndex = 6;
            // 
            // buttonToMenuW2
            // 
            this.buttonToMenuW2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonToMenuW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMenuW2.Location = new System.Drawing.Point(269, 191);
            this.buttonToMenuW2.Name = "buttonToMenuW2";
            this.buttonToMenuW2.Size = new System.Drawing.Size(120, 59);
            this.buttonToMenuW2.TabIndex = 7;
            this.buttonToMenuW2.UseVisualStyleBackColor = false;
            this.buttonToMenuW2.Click += new System.EventHandler(this.ButtonToMenuW2_Click);
            // 
            // buttonExitW2
            // 
            this.buttonExitW2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExitW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitW2.Location = new System.Drawing.Point(16, 191);
            this.buttonExitW2.Name = "buttonExitW2";
            this.buttonExitW2.Size = new System.Drawing.Size(120, 59);
            this.buttonExitW2.TabIndex = 5;
            this.buttonExitW2.UseVisualStyleBackColor = false;
            this.buttonExitW2.Click += new System.EventHandler(this.ButtonExitW2_Click);
            // 
            // buttonWithdrawConfirm
            // 
            this.buttonWithdrawConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.buttonWithdrawConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdrawConfirm.Location = new System.Drawing.Point(143, 191);
            this.buttonWithdrawConfirm.Name = "buttonWithdrawConfirm";
            this.buttonWithdrawConfirm.Size = new System.Drawing.Size(120, 59);
            this.buttonWithdrawConfirm.TabIndex = 1;
            this.buttonWithdrawConfirm.UseVisualStyleBackColor = false;
            this.buttonWithdrawConfirm.Click += new System.EventHandler(this.ButtonWithdrawConfirm_Click);
            // 
            // labelWithdraw2
            // 
            this.labelWithdraw2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWithdraw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWithdraw2.Location = new System.Drawing.Point(68, 25);
            this.labelWithdraw2.Name = "labelWithdraw2";
            this.labelWithdraw2.Size = new System.Drawing.Size(276, 144);
            this.labelWithdraw2.TabIndex = 0;
            this.labelWithdraw2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabWithdraw1
            // 
            this.tabWithdraw1.Controls.Add(this.panelWithdraw);
            this.tabWithdraw1.Location = new System.Drawing.Point(4, 25);
            this.tabWithdraw1.Name = "tabWithdraw1";
            this.tabWithdraw1.Size = new System.Drawing.Size(569, 428);
            this.tabWithdraw1.TabIndex = 5;
            this.tabWithdraw1.Text = "Withdraw1";
            this.tabWithdraw1.UseVisualStyleBackColor = true;
            // 
            // panelWithdraw
            // 
            this.panelWithdraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWithdraw.Controls.Add(this.buttonToMenuW1);
            this.panelWithdraw.Controls.Add(this.textWithdraw);
            this.panelWithdraw.Controls.Add(this.buttonExitW1);
            this.panelWithdraw.Controls.Add(this.buttonWithdrawNext);
            this.panelWithdraw.Controls.Add(this.labelWithdraw1);
            this.panelWithdraw.Location = new System.Drawing.Point(81, 86);
            this.panelWithdraw.Name = "panelWithdraw";
            this.panelWithdraw.Size = new System.Drawing.Size(407, 263);
            this.panelWithdraw.TabIndex = 5;
            // 
            // buttonToMenuW1
            // 
            this.buttonToMenuW1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonToMenuW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMenuW1.Location = new System.Drawing.Point(269, 191);
            this.buttonToMenuW1.Name = "buttonToMenuW1";
            this.buttonToMenuW1.Size = new System.Drawing.Size(120, 59);
            this.buttonToMenuW1.TabIndex = 7;
            this.buttonToMenuW1.UseVisualStyleBackColor = false;
            this.buttonToMenuW1.Click += new System.EventHandler(this.ButtonToMenuW1_Click);
            // 
            // textWithdraw
            // 
            this.textWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWithdraw.Location = new System.Drawing.Point(72, 141);
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.Size = new System.Drawing.Size(272, 29);
            this.textWithdraw.TabIndex = 6;
            this.textWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextWithdraw_KeyPress);
            // 
            // buttonExitW1
            // 
            this.buttonExitW1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExitW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitW1.Location = new System.Drawing.Point(16, 191);
            this.buttonExitW1.Name = "buttonExitW1";
            this.buttonExitW1.Size = new System.Drawing.Size(120, 59);
            this.buttonExitW1.TabIndex = 5;
            this.buttonExitW1.UseVisualStyleBackColor = false;
            this.buttonExitW1.Click += new System.EventHandler(this.ButtonExitW1_Click);
            // 
            // buttonWithdrawNext
            // 
            this.buttonWithdrawNext.BackColor = System.Drawing.SystemColors.Control;
            this.buttonWithdrawNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdrawNext.Location = new System.Drawing.Point(143, 191);
            this.buttonWithdrawNext.Name = "buttonWithdrawNext";
            this.buttonWithdrawNext.Size = new System.Drawing.Size(120, 59);
            this.buttonWithdrawNext.TabIndex = 1;
            this.buttonWithdrawNext.UseVisualStyleBackColor = false;
            this.buttonWithdrawNext.Click += new System.EventHandler(this.ButtonWithdrawNext_Click);
            // 
            // labelWithdraw1
            // 
            this.labelWithdraw1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWithdraw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWithdraw1.Location = new System.Drawing.Point(68, 25);
            this.labelWithdraw1.Name = "labelWithdraw1";
            this.labelWithdraw1.Size = new System.Drawing.Size(276, 102);
            this.labelWithdraw1.TabIndex = 0;
            this.labelWithdraw1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabBalance
            // 
            this.tabBalance.Controls.Add(this.panelBalance);
            this.tabBalance.Location = new System.Drawing.Point(4, 25);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Size = new System.Drawing.Size(569, 428);
            this.tabBalance.TabIndex = 4;
            this.tabBalance.Text = "Balance";
            this.tabBalance.UseVisualStyleBackColor = true;
            // 
            // panelBalance
            // 
            this.panelBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBalance.Controls.Add(this.buttonExitB);
            this.panelBalance.Controls.Add(this.buttonToMenuB);
            this.panelBalance.Controls.Add(this.labelBalance);
            this.panelBalance.Location = new System.Drawing.Point(81, 86);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(407, 263);
            this.panelBalance.TabIndex = 4;
            // 
            // buttonExitB
            // 
            this.buttonExitB.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitB.Location = new System.Drawing.Point(16, 191);
            this.buttonExitB.Name = "buttonExitB";
            this.buttonExitB.Size = new System.Drawing.Size(120, 59);
            this.buttonExitB.TabIndex = 5;
            this.buttonExitB.UseVisualStyleBackColor = false;
            this.buttonExitB.Click += new System.EventHandler(this.ButtonExitB_Click);
            // 
            // buttonToMenuB
            // 
            this.buttonToMenuB.BackColor = System.Drawing.SystemColors.Control;
            this.buttonToMenuB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMenuB.Location = new System.Drawing.Point(275, 191);
            this.buttonToMenuB.Name = "buttonToMenuB";
            this.buttonToMenuB.Size = new System.Drawing.Size(120, 59);
            this.buttonToMenuB.TabIndex = 1;
            this.buttonToMenuB.UseVisualStyleBackColor = false;
            this.buttonToMenuB.Click += new System.EventHandler(this.ButtonToMenuB_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(62, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(276, 188);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.Controls.Add(this.panelMenu);
            this.tabMainMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.Size = new System.Drawing.Size(569, 456);
            this.tabMainMenu.TabIndex = 3;
            this.tabMainMenu.Text = "tabMM";
            this.tabMainMenu.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonBalance);
            this.panelMenu.Controls.Add(this.buttonWithdraw);
            this.panelMenu.Controls.Add(this.buttonTransfer);
            this.panelMenu.Controls.Add(this.labelMainMenu);
            this.panelMenu.Location = new System.Drawing.Point(81, 86);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(407, 263);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(16, 191);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 59);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(16, 104);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(120, 59);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBalance.Location = new System.Drawing.Point(275, 19);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(120, 59);
            this.buttonBalance.TabIndex = 3;
            this.buttonBalance.UseVisualStyleBackColor = false;
            this.buttonBalance.Click += new System.EventHandler(this.ButtonBalance_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.SystemColors.Control;
            this.buttonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdraw.Location = new System.Drawing.Point(275, 104);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(120, 59);
            this.buttonWithdraw.TabIndex = 2;
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.ButtonWithdraw_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Location = new System.Drawing.Point(275, 191);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(120, 59);
            this.buttonTransfer.TabIndex = 1;
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.ButtonTransfer_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainMenu.Location = new System.Drawing.Point(62, 0);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(276, 263);
            this.labelMainMenu.TabIndex = 0;
            this.labelMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPin
            // 
            this.tabPin.Controls.Add(this.panelPin);
            this.tabPin.Location = new System.Drawing.Point(4, 25);
            this.tabPin.Name = "tabPin";
            this.tabPin.Size = new System.Drawing.Size(569, 428);
            this.tabPin.TabIndex = 2;
            this.tabPin.Text = "Pin";
            this.tabPin.UseVisualStyleBackColor = true;
            // 
            // panelPin
            // 
            this.panelPin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPin.Controls.Add(this.ButtonEnterPin);
            this.panelPin.Controls.Add(this.MaskedPinTextBox);
            this.panelPin.Controls.Add(this.labelPin);
            this.panelPin.Location = new System.Drawing.Point(81, 86);
            this.panelPin.Name = "panelPin";
            this.panelPin.Size = new System.Drawing.Size(407, 263);
            this.panelPin.TabIndex = 2;
            // 
            // ButtonEnterPin
            // 
            this.ButtonEnterPin.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonEnterPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEnterPin.Location = new System.Drawing.Point(274, 193);
            this.ButtonEnterPin.Name = "ButtonEnterPin";
            this.ButtonEnterPin.Size = new System.Drawing.Size(120, 59);
            this.ButtonEnterPin.TabIndex = 3;
            this.ButtonEnterPin.Text = "Ввід\r\nEnter";
            this.ButtonEnterPin.UseVisualStyleBackColor = false;
            this.ButtonEnterPin.Click += new System.EventHandler(this.ButtonEnterPin_Click);
            // 
            // MaskedPinTextBox
            // 
            this.MaskedPinTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MaskedPinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskedPinTextBox.Location = new System.Drawing.Point(159, 193);
            this.MaskedPinTextBox.Mask = "0000";
            this.MaskedPinTextBox.Name = "MaskedPinTextBox";
            this.MaskedPinTextBox.PasswordChar = '*';
            this.MaskedPinTextBox.PromptChar = ' ';
            this.MaskedPinTextBox.Size = new System.Drawing.Size(71, 35);
            this.MaskedPinTextBox.TabIndex = 4;
            this.MaskedPinTextBox.UseSystemPasswordChar = true;
            this.MaskedPinTextBox.ValidatingType = typeof(int);
            this.MaskedPinTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaskedPinTextBox_MouseClick);
            this.MaskedPinTextBox.Enter += new System.EventHandler(this.MaskedPinTextBox_Enter);
            this.MaskedPinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedPinTextBox_KeyPress);
            // 
            // labelPin
            // 
            this.labelPin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPin.Location = new System.Drawing.Point(67, 0);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(276, 263);
            this.labelPin.TabIndex = 0;
            this.labelPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLanguage
            // 
            this.tabLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.tabLanguage.Controls.Add(this.panelLanguage);
            this.tabLanguage.Location = new System.Drawing.Point(4, 25);
            this.tabLanguage.Name = "tabLanguage";
            this.tabLanguage.Padding = new System.Windows.Forms.Padding(3);
            this.tabLanguage.Size = new System.Drawing.Size(569, 428);
            this.tabLanguage.TabIndex = 0;
            this.tabLanguage.Text = "Language";
            // 
            // panelLanguage
            // 
            this.panelLanguage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLanguage.Controls.Add(this.ChangeLangButEng);
            this.panelLanguage.Controls.Add(this.ChangeLangButUkr);
            this.panelLanguage.Controls.Add(this.labelLang);
            this.panelLanguage.Location = new System.Drawing.Point(85, 86);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(407, 263);
            this.panelLanguage.TabIndex = 1;
            // 
            // ChangeLangButEng
            // 
            this.ChangeLangButEng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeLangButEng.BackgroundImage")));
            this.ChangeLangButEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeLangButEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLangButEng.Location = new System.Drawing.Point(307, 162);
            this.ChangeLangButEng.Name = "ChangeLangButEng";
            this.ChangeLangButEng.Size = new System.Drawing.Size(87, 53);
            this.ChangeLangButEng.TabIndex = 5;
            this.ChangeLangButEng.UseVisualStyleBackColor = true;
            this.ChangeLangButEng.Click += new System.EventHandler(this.ChangeLangButEng_Click);
            // 
            // ChangeLangButUkr
            // 
            this.ChangeLangButUkr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeLangButUkr.BackgroundImage")));
            this.ChangeLangButUkr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeLangButUkr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLangButUkr.Location = new System.Drawing.Point(307, 52);
            this.ChangeLangButUkr.Name = "ChangeLangButUkr";
            this.ChangeLangButUkr.Size = new System.Drawing.Size(87, 53);
            this.ChangeLangButUkr.TabIndex = 4;
            this.ChangeLangButUkr.UseVisualStyleBackColor = true;
            this.ChangeLangButUkr.Click += new System.EventHandler(this.ChangeLangButUkr_Click);
            // 
            // labelLang
            // 
            this.labelLang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLang.Location = new System.Drawing.Point(62, 0);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(276, 263);
            this.labelLang.TabIndex = 0;
            this.labelLang.Text = "Оберіть мову\r\nChoose language";
            this.labelLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.panelWelcome);
            this.tabWelcome.Location = new System.Drawing.Point(4, 25);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(569, 428);
            this.tabWelcome.TabIndex = 1;
            this.tabWelcome.Text = "Welcome page";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWelcome.Controls.Add(this.buttonInsertCard);
            this.panelWelcome.Controls.Add(this.LabelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(81, 86);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(407, 263);
            this.panelWelcome.TabIndex = 2;
            // 
            // buttonInsertCard
            // 
            this.buttonInsertCard.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInsertCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertCard.Location = new System.Drawing.Point(267, 185);
            this.buttonInsertCard.Name = "buttonInsertCard";
            this.buttonInsertCard.Size = new System.Drawing.Size(120, 59);
            this.buttonInsertCard.TabIndex = 2;
            this.buttonInsertCard.Text = "Вставити карту\r\nInsert card";
            this.buttonInsertCard.UseVisualStyleBackColor = false;
            this.buttonInsertCard.Click += new System.EventHandler(this.ButtonInsertCard_Click);
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWelcome.Location = new System.Drawing.Point(62, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(276, 263);
            this.LabelWelcome.TabIndex = 0;
            this.LabelWelcome.Text = "Вставьте карту \r\nInsert card";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabFrames1
            // 
            this.TabFrames1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabFrames1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabFrames1.Controls.Add(this.tabWelcome);
            this.TabFrames1.Controls.Add(this.tabLanguage);
            this.TabFrames1.Controls.Add(this.tabPin);
            this.TabFrames1.Controls.Add(this.tabMainMenu);
            this.TabFrames1.Controls.Add(this.tabBalance);
            this.TabFrames1.Controls.Add(this.tabWithdraw1);
            this.TabFrames1.Controls.Add(this.tabWithdraw2);
            this.TabFrames1.Controls.Add(this.tabTransfer1);
            this.TabFrames1.Controls.Add(this.tabSettings);
            this.TabFrames1.Controls.Add(this.tabChangePin);
            this.TabFrames1.Location = new System.Drawing.Point(0, 3);
            this.TabFrames1.Name = "TabFrames1";
            this.TabFrames1.SelectedIndex = 0;
            this.TabFrames1.Size = new System.Drawing.Size(577, 457);
            this.TabFrames1.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.panelSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(569, 456);
            this.tabSettings.TabIndex = 8;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSettings.Controls.Add(this.buttonExitS);
            this.panelSettings.Controls.Add(this.buttonChangePin);
            this.panelSettings.Controls.Add(this.buttonToMenuS);
            this.panelSettings.Location = new System.Drawing.Point(81, 83);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(407, 263);
            this.panelSettings.TabIndex = 4;
            // 
            // buttonExitS
            // 
            this.buttonExitS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExitS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitS.Location = new System.Drawing.Point(16, 191);
            this.buttonExitS.Name = "buttonExitS";
            this.buttonExitS.Size = new System.Drawing.Size(120, 59);
            this.buttonExitS.TabIndex = 5;
            this.buttonExitS.UseVisualStyleBackColor = false;
            this.buttonExitS.Click += new System.EventHandler(this.ButtonExitS_Click);
            // 
            // buttonChangePin
            // 
            this.buttonChangePin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonChangePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePin.Location = new System.Drawing.Point(275, 104);
            this.buttonChangePin.Name = "buttonChangePin";
            this.buttonChangePin.Size = new System.Drawing.Size(120, 59);
            this.buttonChangePin.TabIndex = 2;
            this.buttonChangePin.UseVisualStyleBackColor = false;
            this.buttonChangePin.Click += new System.EventHandler(this.ButtonChangePin_Click);
            // 
            // buttonToMenuS
            // 
            this.buttonToMenuS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonToMenuS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMenuS.Location = new System.Drawing.Point(275, 191);
            this.buttonToMenuS.Name = "buttonToMenuS";
            this.buttonToMenuS.Size = new System.Drawing.Size(120, 59);
            this.buttonToMenuS.TabIndex = 1;
            this.buttonToMenuS.UseVisualStyleBackColor = false;
            this.buttonToMenuS.Click += new System.EventHandler(this.ButtonToMenuS_Click);
            // 
            // tabChangePin
            // 
            this.tabChangePin.BackColor = System.Drawing.SystemColors.Control;
            this.tabChangePin.Controls.Add(this.panel1);
            this.tabChangePin.Location = new System.Drawing.Point(4, 25);
            this.tabChangePin.Name = "tabChangePin";
            this.tabChangePin.Size = new System.Drawing.Size(569, 456);
            this.tabChangePin.TabIndex = 9;
            this.tabChangePin.Text = "ChangePin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.maskedNewPin);
            this.panel1.Controls.Add(this.LabelNewPin);
            this.panel1.Controls.Add(this.labelOldPin);
            this.panel1.Controls.Add(this.maskedOldPin);
            this.panel1.Controls.Add(this.buttonToMenuSC);
            this.panel1.Controls.Add(this.ButtonExitSC);
            this.panel1.Controls.Add(this.buttonNextSC);
            this.panel1.Controls.Add(this.labelChangePin);
            this.panel1.Location = new System.Drawing.Point(81, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 263);
            this.panel1.TabIndex = 7;
            // 
            // maskedNewPin
            // 
            this.maskedNewPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedNewPin.Location = new System.Drawing.Point(166, 141);
            this.maskedNewPin.Mask = "0000";
            this.maskedNewPin.Name = "maskedNewPin";
            this.maskedNewPin.PromptChar = ' ';
            this.maskedNewPin.Size = new System.Drawing.Size(73, 26);
            this.maskedNewPin.TabIndex = 12;
            this.maskedNewPin.UseSystemPasswordChar = true;
            this.maskedNewPin.ValidatingType = typeof(int);
            // 
            // LabelNewPin
            // 
            this.LabelNewPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNewPin.Location = new System.Drawing.Point(16, 141);
            this.LabelNewPin.Name = "LabelNewPin";
            this.LabelNewPin.Size = new System.Drawing.Size(121, 26);
            this.LabelNewPin.TabIndex = 11;
            // 
            // labelOldPin
            // 
            this.labelOldPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOldPin.Location = new System.Drawing.Point(16, 109);
            this.labelOldPin.Name = "labelOldPin";
            this.labelOldPin.Size = new System.Drawing.Size(120, 26);
            this.labelOldPin.TabIndex = 10;
            // 
            // maskedOldPin
            // 
            this.maskedOldPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedOldPin.Location = new System.Drawing.Point(166, 109);
            this.maskedOldPin.Mask = "0000";
            this.maskedOldPin.Name = "maskedOldPin";
            this.maskedOldPin.PromptChar = ' ';
            this.maskedOldPin.Size = new System.Drawing.Size(73, 26);
            this.maskedOldPin.TabIndex = 8;
            this.maskedOldPin.UseSystemPasswordChar = true;
            this.maskedOldPin.ValidatingType = typeof(int);
            // 
            // buttonToMenuSC
            // 
            this.buttonToMenuSC.BackColor = System.Drawing.SystemColors.Control;
            this.buttonToMenuSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMenuSC.Location = new System.Drawing.Point(269, 191);
            this.buttonToMenuSC.Name = "buttonToMenuSC";
            this.buttonToMenuSC.Size = new System.Drawing.Size(120, 59);
            this.buttonToMenuSC.TabIndex = 7;
            this.buttonToMenuSC.UseVisualStyleBackColor = false;
            this.buttonToMenuSC.Click += new System.EventHandler(this.ButtonToMenuSC_Click);
            // 
            // ButtonExitSC
            // 
            this.ButtonExitSC.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonExitSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExitSC.Location = new System.Drawing.Point(16, 191);
            this.ButtonExitSC.Name = "ButtonExitSC";
            this.ButtonExitSC.Size = new System.Drawing.Size(120, 59);
            this.ButtonExitSC.TabIndex = 5;
            this.ButtonExitSC.UseVisualStyleBackColor = false;
            this.ButtonExitSC.Click += new System.EventHandler(this.ButtonExitSC_Click);
            // 
            // buttonNextSC
            // 
            this.buttonNextSC.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNextSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextSC.Location = new System.Drawing.Point(143, 191);
            this.buttonNextSC.Name = "buttonNextSC";
            this.buttonNextSC.Size = new System.Drawing.Size(120, 59);
            this.buttonNextSC.TabIndex = 1;
            this.buttonNextSC.UseVisualStyleBackColor = false;
            this.buttonNextSC.Click += new System.EventHandler(this.ButtonNextSC_Click);
            // 
            // labelChangePin
            // 
            this.labelChangePin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangePin.Location = new System.Drawing.Point(68, 14);
            this.labelChangePin.Name = "labelChangePin";
            this.labelChangePin.Size = new System.Drawing.Size(276, 79);
            this.labelChangePin.TabIndex = 0;
            this.labelChangePin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 462);
            this.Controls.Add(this.TabFrames1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.tabTransfer1.ResumeLayout(false);
            this.panelTransfer.ResumeLayout(false);
            this.panelTransfer.PerformLayout();
            this.tabWithdraw2.ResumeLayout(false);
            this.panelWithdraw2.ResumeLayout(false);
            this.tabWithdraw1.ResumeLayout(false);
            this.panelWithdraw.ResumeLayout(false);
            this.panelWithdraw.PerformLayout();
            this.tabBalance.ResumeLayout(false);
            this.panelBalance.ResumeLayout(false);
            this.tabMainMenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.tabPin.ResumeLayout(false);
            this.panelPin.ResumeLayout(false);
            this.panelPin.PerformLayout();
            this.tabLanguage.ResumeLayout(false);
            this.panelLanguage.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.TabFrames1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.tabChangePin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openCardDialog1;
        private System.Windows.Forms.TabPage tabTransfer1;
        private System.Windows.Forms.Panel panelTransfer;
        private System.Windows.Forms.TextBox textTAmount;
        private System.Windows.Forms.Label labelTAmount;
        private System.Windows.Forms.Label labelTCard;
        private System.Windows.Forms.MaskedTextBox maskedTCardNumber;
        private System.Windows.Forms.Button buttonToMenuT1;
        private System.Windows.Forms.Button buttonExitT1;
        private System.Windows.Forms.Button buttonNextT1;
        private System.Windows.Forms.Label labelTransfer1;
        private System.Windows.Forms.TabPage tabWithdraw2;
        private System.Windows.Forms.Panel panelWithdraw2;
        private System.Windows.Forms.Button buttonToMenuW2;
        private System.Windows.Forms.Button buttonExitW2;
        private System.Windows.Forms.Button buttonWithdrawConfirm;
        private System.Windows.Forms.Label labelWithdraw2;
        private System.Windows.Forms.TabPage tabWithdraw1;
        private System.Windows.Forms.Panel panelWithdraw;
        private System.Windows.Forms.Button buttonToMenuW1;
        private System.Windows.Forms.TextBox textWithdraw;
        private System.Windows.Forms.Button buttonExitW1;
        private System.Windows.Forms.Button buttonWithdrawNext;
        private System.Windows.Forms.Label labelWithdraw1;
        private System.Windows.Forms.TabPage tabBalance;
        private System.Windows.Forms.Panel panelBalance;
        private System.Windows.Forms.Button buttonExitB;
        private System.Windows.Forms.Button buttonToMenuB;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TabPage tabMainMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.TabPage tabPin;
        private System.Windows.Forms.Panel panelPin;
        private System.Windows.Forms.Button ButtonEnterPin;
        private System.Windows.Forms.MaskedTextBox MaskedPinTextBox;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.TabPage tabLanguage;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.Button ChangeLangButEng;
        private System.Windows.Forms.Button ChangeLangButUkr;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Button buttonInsertCard;
        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.TabControl TabFrames1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button buttonExitS;
        private System.Windows.Forms.Button buttonChangePin;
        private System.Windows.Forms.Button buttonToMenuS;
        private System.Windows.Forms.TabPage tabChangePin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedNewPin;
        private System.Windows.Forms.Label LabelNewPin;
        private System.Windows.Forms.Label labelOldPin;
        private System.Windows.Forms.MaskedTextBox maskedOldPin;
        private System.Windows.Forms.Button buttonToMenuSC;
        private System.Windows.Forms.Button ButtonExitSC;
        private System.Windows.Forms.Button buttonNextSC;
        private System.Windows.Forms.Label labelChangePin;
    }
}

