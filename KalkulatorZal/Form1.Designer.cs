
namespace KalkulatorZal
{
    partial class Kalkulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayLabel = new System.Windows.Forms.Label();
            this.numberButton7 = new System.Windows.Forms.Button();
            this.numberButton8 = new System.Windows.Forms.Button();
            this.numberButton9 = new System.Windows.Forms.Button();
            this.numberButton6 = new System.Windows.Forms.Button();
            this.numberButton5 = new System.Windows.Forms.Button();
            this.numberButton4 = new System.Windows.Forms.Button();
            this.numberButton3 = new System.Windows.Forms.Button();
            this.numberButton2 = new System.Windows.Forms.Button();
            this.numberButton1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.numberButton0 = new System.Windows.Forms.Button();
            this.positiveNegativeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resetLastButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.powButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.lnButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.ctgButton = new System.Windows.Forms.Button();
            this.reciprocalButton = new System.Windows.Forms.Button();
            this.tgButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.decRadioButton = new System.Windows.Forms.RadioButton();
            this.hexRadioButton = new System.Windows.Forms.RadioButton();
            this.binRadioButton = new System.Windows.Forms.RadioButton();
            this.octRadioButton = new System.Windows.Forms.RadioButton();
            this.rightBracketButton = new System.Windows.Forms.Button();
            this.leftBracketButton = new System.Windows.Forms.Button();
            this.numberButtonE = new System.Windows.Forms.Button();
            this.numberButtonA = new System.Windows.Forms.Button();
            this.numberButtonB = new System.Windows.Forms.Button();
            this.numberButtonC = new System.Windows.Forms.Button();
            this.numberButtonD = new System.Windows.Forms.Button();
            this.numberButtonF = new System.Windows.Forms.Button();
            this.andButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.orButton = new System.Windows.Forms.Button();
            this.memoryAddButton = new System.Windows.Forms.Button();
            this.memoryRecallButton = new System.Windows.Forms.Button();
            this.memorySubstractButton = new System.Windows.Forms.Button();
            this.memoryClearButton = new System.Windows.Forms.Button();
            this.scienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scienceToolStripMenuItem,
            this.programmerToolStripMenuItem,
            this.historiaToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmerToolStripMenuItem.Text = "Programisty";
            this.programmerToolStripMenuItem.Click += new System.EventHandler(this.programmerToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.White;
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayLabel.Location = new System.Drawing.Point(66, 105);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(362, 51);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "0";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberButton7
            // 
            this.numberButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton7.Location = new System.Drawing.Point(66, 330);
            this.numberButton7.Name = "numberButton7";
            this.numberButton7.Size = new System.Drawing.Size(50, 50);
            this.numberButton7.TabIndex = 3;
            this.numberButton7.Text = "7";
            this.numberButton7.UseVisualStyleBackColor = true;
            this.numberButton7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton8
            // 
            this.numberButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton8.Location = new System.Drawing.Point(122, 330);
            this.numberButton8.Name = "numberButton8";
            this.numberButton8.Size = new System.Drawing.Size(50, 50);
            this.numberButton8.TabIndex = 4;
            this.numberButton8.Text = "8";
            this.numberButton8.UseVisualStyleBackColor = true;
            this.numberButton8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton9
            // 
            this.numberButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton9.Location = new System.Drawing.Point(178, 330);
            this.numberButton9.Name = "numberButton9";
            this.numberButton9.Size = new System.Drawing.Size(50, 50);
            this.numberButton9.TabIndex = 5;
            this.numberButton9.Text = "9";
            this.numberButton9.UseVisualStyleBackColor = true;
            this.numberButton9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton6
            // 
            this.numberButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton6.Location = new System.Drawing.Point(178, 386);
            this.numberButton6.Name = "numberButton6";
            this.numberButton6.Size = new System.Drawing.Size(50, 50);
            this.numberButton6.TabIndex = 8;
            this.numberButton6.Text = "6";
            this.numberButton6.UseVisualStyleBackColor = true;
            this.numberButton6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton5
            // 
            this.numberButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton5.Location = new System.Drawing.Point(122, 386);
            this.numberButton5.Name = "numberButton5";
            this.numberButton5.Size = new System.Drawing.Size(50, 50);
            this.numberButton5.TabIndex = 7;
            this.numberButton5.Text = "5";
            this.numberButton5.UseVisualStyleBackColor = true;
            this.numberButton5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton4
            // 
            this.numberButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton4.Location = new System.Drawing.Point(66, 386);
            this.numberButton4.Name = "numberButton4";
            this.numberButton4.Size = new System.Drawing.Size(50, 50);
            this.numberButton4.TabIndex = 6;
            this.numberButton4.Text = "4";
            this.numberButton4.UseVisualStyleBackColor = true;
            this.numberButton4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton3
            // 
            this.numberButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton3.Location = new System.Drawing.Point(178, 442);
            this.numberButton3.Name = "numberButton3";
            this.numberButton3.Size = new System.Drawing.Size(50, 50);
            this.numberButton3.TabIndex = 11;
            this.numberButton3.Text = "3";
            this.numberButton3.UseVisualStyleBackColor = true;
            this.numberButton3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton2
            // 
            this.numberButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton2.Location = new System.Drawing.Point(122, 442);
            this.numberButton2.Name = "numberButton2";
            this.numberButton2.Size = new System.Drawing.Size(50, 50);
            this.numberButton2.TabIndex = 10;
            this.numberButton2.Text = "2";
            this.numberButton2.UseVisualStyleBackColor = true;
            this.numberButton2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButton1
            // 
            this.numberButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton1.Location = new System.Drawing.Point(66, 442);
            this.numberButton1.Name = "numberButton1";
            this.numberButton1.Size = new System.Drawing.Size(50, 50);
            this.numberButton1.TabIndex = 9;
            this.numberButton1.Text = "1";
            this.numberButton1.UseVisualStyleBackColor = true;
            this.numberButton1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(234, 442);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 50);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplyButton.Location = new System.Drawing.Point(234, 330);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(50, 50);
            this.multiplyButton.TabIndex = 13;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(178, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Del";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalsButton.Location = new System.Drawing.Point(234, 498);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(50, 50);
            this.equalsButton.TabIndex = 16;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click_1);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtractButton.Location = new System.Drawing.Point(234, 386);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(50, 50);
            this.subtractButton.TabIndex = 15;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dotButton.Location = new System.Drawing.Point(178, 498);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(50, 50);
            this.dotButton.TabIndex = 19;
            this.dotButton.Text = ",";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // numberButton0
            // 
            this.numberButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButton0.Location = new System.Drawing.Point(122, 498);
            this.numberButton0.Name = "numberButton0";
            this.numberButton0.Size = new System.Drawing.Size(50, 50);
            this.numberButton0.TabIndex = 18;
            this.numberButton0.Text = "0";
            this.numberButton0.UseVisualStyleBackColor = true;
            this.numberButton0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // positiveNegativeButton
            // 
            this.positiveNegativeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.positiveNegativeButton.Location = new System.Drawing.Point(66, 498);
            this.positiveNegativeButton.Name = "positiveNegativeButton";
            this.positiveNegativeButton.Size = new System.Drawing.Size(50, 50);
            this.positiveNegativeButton.TabIndex = 17;
            this.positiveNegativeButton.Text = "+/-";
            this.positiveNegativeButton.UseVisualStyleBackColor = true;
            this.positiveNegativeButton.Click += new System.EventHandler(this.positiveNegativeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(124, 218);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 50);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resetLastButton
            // 
            this.resetLastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetLastButton.Location = new System.Drawing.Point(68, 218);
            this.resetLastButton.Name = "resetLastButton";
            this.resetLastButton.Size = new System.Drawing.Size(50, 50);
            this.resetLastButton.TabIndex = 22;
            this.resetLastButton.Text = "CE";
            this.resetLastButton.UseVisualStyleBackColor = true;
            this.resetLastButton.Click += new System.EventHandler(this.resetLastButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divideButton.Location = new System.Drawing.Point(234, 274);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(50, 50);
            this.divideButton.TabIndex = 21;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayTextBox.Location = new System.Drawing.Point(66, 54);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(362, 48);
            this.displayTextBox.TabIndex = 23;
            this.displayTextBox.TextChanged += new System.EventHandler(this.displayTextBox_TextChanged);
            // 
            // powButton
            // 
            this.powButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powButton.Location = new System.Drawing.Point(322, 274);
            this.powButton.Name = "powButton";
            this.powButton.Size = new System.Drawing.Size(50, 50);
            this.powButton.TabIndex = 28;
            this.powButton.Text = "^";
            this.powButton.UseVisualStyleBackColor = true;
            this.powButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cosButton.Location = new System.Drawing.Point(322, 498);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(50, 50);
            this.cosButton.TabIndex = 27;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.cosButton_Click);
            // 
            // lnButton
            // 
            this.lnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnButton.Location = new System.Drawing.Point(322, 386);
            this.lnButton.Name = "lnButton";
            this.lnButton.Size = new System.Drawing.Size(50, 50);
            this.lnButton.TabIndex = 26;
            this.lnButton.Text = "ln";
            this.lnButton.UseVisualStyleBackColor = true;
            this.lnButton.Click += new System.EventHandler(this.lnButton_Click);
            // 
            // sinButton
            // 
            this.sinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sinButton.Location = new System.Drawing.Point(322, 442);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(50, 50);
            this.sinButton.TabIndex = 25;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.sinButton_Click);
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logButton.Location = new System.Drawing.Point(322, 330);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(50, 50);
            this.logButton.TabIndex = 24;
            this.logButton.Text = "log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqrtButton.Location = new System.Drawing.Point(378, 274);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(50, 50);
            this.sqrtButton.TabIndex = 33;
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // ctgButton
            // 
            this.ctgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctgButton.Location = new System.Drawing.Point(378, 498);
            this.ctgButton.Name = "ctgButton";
            this.ctgButton.Size = new System.Drawing.Size(50, 50);
            this.ctgButton.TabIndex = 32;
            this.ctgButton.Text = "ctg";
            this.ctgButton.UseVisualStyleBackColor = true;
            this.ctgButton.Click += new System.EventHandler(this.ctgButton_Click);
            // 
            // reciprocalButton
            // 
            this.reciprocalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reciprocalButton.Location = new System.Drawing.Point(378, 386);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.Size = new System.Drawing.Size(50, 50);
            this.reciprocalButton.TabIndex = 31;
            this.reciprocalButton.Text = "1/x";
            this.reciprocalButton.UseVisualStyleBackColor = true;
            this.reciprocalButton.Click += new System.EventHandler(this.reciprocalButton_Click);
            // 
            // tgButton
            // 
            this.tgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tgButton.Location = new System.Drawing.Point(378, 442);
            this.tgButton.Name = "tgButton";
            this.tgButton.Size = new System.Drawing.Size(50, 50);
            this.tgButton.TabIndex = 30;
            this.tgButton.Text = "tg";
            this.tgButton.UseVisualStyleBackColor = true;
            this.tgButton.Click += new System.EventHandler(this.tgButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.factorialButton.Location = new System.Drawing.Point(378, 330);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(50, 50);
            this.factorialButton.TabIndex = 29;
            this.factorialButton.Text = "!";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // decRadioButton
            // 
            this.decRadioButton.AutoSize = true;
            this.decRadioButton.Checked = true;
            this.decRadioButton.Location = new System.Drawing.Point(87, 171);
            this.decRadioButton.Name = "decRadioButton";
            this.decRadioButton.Size = new System.Drawing.Size(47, 17);
            this.decRadioButton.TabIndex = 34;
            this.decRadioButton.TabStop = true;
            this.decRadioButton.Text = "DEC";
            this.decRadioButton.UseVisualStyleBackColor = true;
            this.decRadioButton.Visible = false;
            this.decRadioButton.CheckedChanged += new System.EventHandler(this.decRadioButton_CheckedChanged);
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.AutoSize = true;
            this.hexRadioButton.Location = new System.Drawing.Point(178, 171);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(47, 17);
            this.hexRadioButton.TabIndex = 35;
            this.hexRadioButton.Text = "HEX";
            this.hexRadioButton.UseVisualStyleBackColor = true;
            this.hexRadioButton.Visible = false;
            this.hexRadioButton.CheckedChanged += new System.EventHandler(this.hexRadioButton_CheckedChanged);
            // 
            // binRadioButton
            // 
            this.binRadioButton.AutoSize = true;
            this.binRadioButton.Location = new System.Drawing.Point(269, 171);
            this.binRadioButton.Name = "binRadioButton";
            this.binRadioButton.Size = new System.Drawing.Size(43, 17);
            this.binRadioButton.TabIndex = 36;
            this.binRadioButton.Text = "BIN";
            this.binRadioButton.UseVisualStyleBackColor = true;
            this.binRadioButton.Visible = false;
            this.binRadioButton.CheckedChanged += new System.EventHandler(this.binRadioButton_CheckedChanged);
            // 
            // octRadioButton
            // 
            this.octRadioButton.AutoSize = true;
            this.octRadioButton.Location = new System.Drawing.Point(360, 171);
            this.octRadioButton.Name = "octRadioButton";
            this.octRadioButton.Size = new System.Drawing.Size(47, 17);
            this.octRadioButton.TabIndex = 37;
            this.octRadioButton.Text = "OCT";
            this.octRadioButton.UseVisualStyleBackColor = true;
            this.octRadioButton.Visible = false;
            this.octRadioButton.CheckedChanged += new System.EventHandler(this.octRadioButton_CheckedChanged);
            // 
            // rightBracketButton
            // 
            this.rightBracketButton.Enabled = false;
            this.rightBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightBracketButton.Location = new System.Drawing.Point(178, 274);
            this.rightBracketButton.Name = "rightBracketButton";
            this.rightBracketButton.Size = new System.Drawing.Size(50, 50);
            this.rightBracketButton.TabIndex = 39;
            this.rightBracketButton.Text = ")";
            this.rightBracketButton.UseVisualStyleBackColor = true;
            this.rightBracketButton.Click += new System.EventHandler(this.rightBracketButton_Click);
            // 
            // leftBracketButton
            // 
            this.leftBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftBracketButton.Location = new System.Drawing.Point(122, 274);
            this.leftBracketButton.Name = "leftBracketButton";
            this.leftBracketButton.Size = new System.Drawing.Size(50, 50);
            this.leftBracketButton.TabIndex = 38;
            this.leftBracketButton.Text = "(";
            this.leftBracketButton.UseVisualStyleBackColor = true;
            this.leftBracketButton.Click += new System.EventHandler(this.BracketClick);
            // 
            // numberButtonE
            // 
            this.numberButtonE.Enabled = false;
            this.numberButtonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButtonE.Location = new System.Drawing.Point(10, 274);
            this.numberButtonE.Name = "numberButtonE";
            this.numberButtonE.Size = new System.Drawing.Size(50, 50);
            this.numberButtonE.TabIndex = 44;
            this.numberButtonE.Text = "E";
            this.numberButtonE.UseVisualStyleBackColor = true;
            this.numberButtonE.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButtonA
            // 
            this.numberButtonA.Enabled = false;
            this.numberButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButtonA.Location = new System.Drawing.Point(10, 498);
            this.numberButtonA.Name = "numberButtonA";
            this.numberButtonA.Size = new System.Drawing.Size(50, 50);
            this.numberButtonA.TabIndex = 43;
            this.numberButtonA.Text = "A";
            this.numberButtonA.UseVisualStyleBackColor = true;
            this.numberButtonA.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButtonB
            // 
            this.numberButtonB.Enabled = false;
            this.numberButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButtonB.Location = new System.Drawing.Point(10, 442);
            this.numberButtonB.Name = "numberButtonB";
            this.numberButtonB.Size = new System.Drawing.Size(50, 50);
            this.numberButtonB.TabIndex = 42;
            this.numberButtonB.Text = "B";
            this.numberButtonB.UseVisualStyleBackColor = true;
            this.numberButtonB.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButtonC
            // 
            this.numberButtonC.Enabled = false;
            this.numberButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButtonC.Location = new System.Drawing.Point(10, 386);
            this.numberButtonC.Name = "numberButtonC";
            this.numberButtonC.Size = new System.Drawing.Size(50, 50);
            this.numberButtonC.TabIndex = 41;
            this.numberButtonC.Text = "C";
            this.numberButtonC.UseVisualStyleBackColor = true;
            this.numberButtonC.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButtonD
            // 
            this.numberButtonD.Enabled = false;
            this.numberButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButtonD.Location = new System.Drawing.Point(10, 330);
            this.numberButtonD.Name = "numberButtonD";
            this.numberButtonD.Size = new System.Drawing.Size(50, 50);
            this.numberButtonD.TabIndex = 40;
            this.numberButtonD.Text = "D";
            this.numberButtonD.UseVisualStyleBackColor = true;
            this.numberButtonD.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numberButtonF
            // 
            this.numberButtonF.Enabled = false;
            this.numberButtonF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberButtonF.Location = new System.Drawing.Point(66, 274);
            this.numberButtonF.Name = "numberButtonF";
            this.numberButtonF.Size = new System.Drawing.Size(50, 50);
            this.numberButtonF.TabIndex = 45;
            this.numberButtonF.Text = "F";
            this.numberButtonF.UseVisualStyleBackColor = true;
            this.numberButtonF.Click += new System.EventHandler(this.ButtonClick);
            // 
            // andButton
            // 
            this.andButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.andButton.Location = new System.Drawing.Point(348, 305);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(59, 50);
            this.andButton.TabIndex = 49;
            this.andButton.Text = "AND";
            this.andButton.UseVisualStyleBackColor = true;
            this.andButton.Visible = false;
            this.andButton.Click += new System.EventHandler(this.andButton_Click);
            // 
            // notButton
            // 
            this.notButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notButton.Location = new System.Drawing.Point(348, 417);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(59, 50);
            this.notButton.TabIndex = 48;
            this.notButton.Text = "NOT";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Visible = false;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // xorButton
            // 
            this.xorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xorButton.Location = new System.Drawing.Point(348, 473);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(59, 50);
            this.xorButton.TabIndex = 47;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Visible = false;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // orButton
            // 
            this.orButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orButton.Location = new System.Drawing.Point(348, 361);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(59, 50);
            this.orButton.TabIndex = 46;
            this.orButton.Text = "OR";
            this.orButton.UseVisualStyleBackColor = true;
            this.orButton.Visible = false;
            this.orButton.Click += new System.EventHandler(this.orButton_Click);
            // 
            // memoryAddButton
            // 
            this.memoryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoryAddButton.Location = new System.Drawing.Point(269, 218);
            this.memoryAddButton.Name = "memoryAddButton";
            this.memoryAddButton.Size = new System.Drawing.Size(50, 50);
            this.memoryAddButton.TabIndex = 53;
            this.memoryAddButton.Text = "M+";
            this.memoryAddButton.UseVisualStyleBackColor = true;
            this.memoryAddButton.Click += new System.EventHandler(this.memoryAddButton_Click);
            // 
            // memoryRecallButton
            // 
            this.memoryRecallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoryRecallButton.Location = new System.Drawing.Point(381, 218);
            this.memoryRecallButton.Name = "memoryRecallButton";
            this.memoryRecallButton.Size = new System.Drawing.Size(50, 50);
            this.memoryRecallButton.TabIndex = 52;
            this.memoryRecallButton.Text = "MR";
            this.memoryRecallButton.UseVisualStyleBackColor = true;
            this.memoryRecallButton.Click += new System.EventHandler(this.memoryRecallButton_Click);
            // 
            // memorySubstractButton
            // 
            this.memorySubstractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memorySubstractButton.Location = new System.Drawing.Point(325, 218);
            this.memorySubstractButton.Name = "memorySubstractButton";
            this.memorySubstractButton.Size = new System.Drawing.Size(50, 50);
            this.memorySubstractButton.TabIndex = 51;
            this.memorySubstractButton.Text = "M-";
            this.memorySubstractButton.UseVisualStyleBackColor = true;
            this.memorySubstractButton.Click += new System.EventHandler(this.memorySubstractButton_Click);
            // 
            // memoryClearButton
            // 
            this.memoryClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoryClearButton.Location = new System.Drawing.Point(437, 218);
            this.memoryClearButton.Name = "memoryClearButton";
            this.memoryClearButton.Size = new System.Drawing.Size(50, 50);
            this.memoryClearButton.TabIndex = 50;
            this.memoryClearButton.Text = "MC";
            this.memoryClearButton.UseVisualStyleBackColor = true;
            this.memoryClearButton.Click += new System.EventHandler(this.memoryClearButton_Click);
            // 
            // scienceToolStripMenuItem
            // 
            this.scienceToolStripMenuItem.Checked = true;
            this.scienceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scienceToolStripMenuItem.Name = "scienceToolStripMenuItem";
            this.scienceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scienceToolStripMenuItem.Text = "Naukowy";
            this.scienceToolStripMenuItem.Click += new System.EventHandler(this.programmerToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historiaToolStripMenuItem.Text = "Historia";
            this.historiaToolStripMenuItem.Click += new System.EventHandler(this.historiaToolStripMenuItem_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 569);
            this.Controls.Add(this.memoryAddButton);
            this.Controls.Add(this.memoryRecallButton);
            this.Controls.Add(this.memorySubstractButton);
            this.Controls.Add(this.memoryClearButton);
            this.Controls.Add(this.andButton);
            this.Controls.Add(this.notButton);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.orButton);
            this.Controls.Add(this.numberButtonF);
            this.Controls.Add(this.numberButtonE);
            this.Controls.Add(this.numberButtonA);
            this.Controls.Add(this.numberButtonB);
            this.Controls.Add(this.numberButtonC);
            this.Controls.Add(this.numberButtonD);
            this.Controls.Add(this.rightBracketButton);
            this.Controls.Add(this.leftBracketButton);
            this.Controls.Add(this.octRadioButton);
            this.Controls.Add(this.binRadioButton);
            this.Controls.Add(this.hexRadioButton);
            this.Controls.Add(this.decRadioButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.ctgButton);
            this.Controls.Add(this.reciprocalButton);
            this.Controls.Add(this.tgButton);
            this.Controls.Add(this.factorialButton);
            this.Controls.Add(this.powButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.lnButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.resetLastButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.numberButton0);
            this.Controls.Add(this.positiveNegativeButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.numberButton3);
            this.Controls.Add(this.numberButton2);
            this.Controls.Add(this.numberButton1);
            this.Controls.Add(this.numberButton6);
            this.Controls.Add(this.numberButton5);
            this.Controls.Add(this.numberButton4);
            this.Controls.Add(this.numberButton9);
            this.Controls.Add(this.numberButton8);
            this.Controls.Add(this.numberButton7);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Kalkulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.Button numberButton7;
        private System.Windows.Forms.Button numberButton8;
        private System.Windows.Forms.Button numberButton9;
        private System.Windows.Forms.Button numberButton6;
        private System.Windows.Forms.Button numberButton5;
        private System.Windows.Forms.Button numberButton4;
        private System.Windows.Forms.Button numberButton3;
        private System.Windows.Forms.Button numberButton2;
        private System.Windows.Forms.Button numberButton1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button numberButton0;
        private System.Windows.Forms.Button positiveNegativeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resetLastButton;
        private System.Windows.Forms.Button divideButton;
        public System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button powButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button lnButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button ctgButton;
        private System.Windows.Forms.Button reciprocalButton;
        private System.Windows.Forms.Button tgButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.RadioButton decRadioButton;
        private System.Windows.Forms.RadioButton hexRadioButton;
        private System.Windows.Forms.RadioButton binRadioButton;
        private System.Windows.Forms.RadioButton octRadioButton;
        private System.Windows.Forms.Button rightBracketButton;
        private System.Windows.Forms.Button leftBracketButton;
        private System.Windows.Forms.Button numberButtonE;
        private System.Windows.Forms.Button numberButtonA;
        private System.Windows.Forms.Button numberButtonB;
        private System.Windows.Forms.Button numberButtonC;
        private System.Windows.Forms.Button numberButtonD;
        private System.Windows.Forms.Button numberButtonF;
        private System.Windows.Forms.Button andButton;
        private System.Windows.Forms.Button notButton;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Button orButton;
        private System.Windows.Forms.Button memoryAddButton;
        private System.Windows.Forms.Button memoryRecallButton;
        private System.Windows.Forms.Button memorySubstractButton;
        private System.Windows.Forms.Button memoryClearButton;
        private System.Windows.Forms.ToolStripMenuItem scienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
    }
}

