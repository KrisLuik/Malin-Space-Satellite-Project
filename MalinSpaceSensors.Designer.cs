namespace MalinSpaceProject
{
    partial class MalinSpaceSensors
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
            this.loadSensorDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listviewDisplaybox = new System.Windows.Forms.ListView();
            this.columnSensorA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSensorB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxDisplaySensorA = new System.Windows.Forms.ListBox();
            this.listBoxDisplaySensorB = new System.Windows.Forms.ListBox();
            this.sigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.muNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iterativeSearchALabel = new System.Windows.Forms.Label();
            this.iterativeSearchBLabel = new System.Windows.Forms.Label();
            this.iterativeSearchSensorABtn = new System.Windows.Forms.Button();
            this.iterativeSearchSensorBBtn = new System.Windows.Forms.Button();
            this.textboxIterativeSensorA = new System.Windows.Forms.TextBox();
            this.textboxIterativeSearchB = new System.Windows.Forms.TextBox();
            this.textboxRecursiveSensorA = new System.Windows.Forms.TextBox();
            this.recusiveSearchSensorABtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxRecursiveSensorB = new System.Windows.Forms.TextBox();
            this.recursiveSearchSensorBBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxSelectionSortSensorA = new System.Windows.Forms.TextBox();
            this.selectionSortSensorABtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxSelectionSortSensorB = new System.Windows.Forms.TextBox();
            this.selectionSortSensorBBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxInsertionSensorA = new System.Windows.Forms.TextBox();
            this.insertionSortSensorABtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textboxInsertionSensorB = new System.Windows.Forms.TextBox();
            this.insertionSortSensorBBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSearchTargetA = new System.Windows.Forms.TextBox();
            this.textBoxSearchTargetB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ClearAllTextBoxesButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadSensorDataButton
            // 
            this.loadSensorDataButton.Location = new System.Drawing.Point(23, 59);
            this.loadSensorDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadSensorDataButton.Name = "loadSensorDataButton";
            this.loadSensorDataButton.Size = new System.Drawing.Size(281, 31);
            this.loadSensorDataButton.TabIndex = 0;
            this.loadSensorDataButton.Text = "Load Sensor Data";
            this.toolTip1.SetToolTip(this.loadSensorDataButton, "Click here to gather raw data");
            this.loadSensorDataButton.UseVisualStyleBackColor = true;
            this.loadSensorDataButton.Click += new System.EventHandler(this.loadSensorDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sigma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sensor A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(883, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sensor B";
            // 
            // listviewDisplaybox
            // 
            this.listviewDisplaybox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSensorA,
            this.columnSensorB});
            this.listviewDisplaybox.GridLines = true;
            this.listviewDisplaybox.HideSelection = false;
            this.listviewDisplaybox.Location = new System.Drawing.Point(23, 96);
            this.listviewDisplaybox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listviewDisplaybox.Name = "listviewDisplaybox";
            this.listviewDisplaybox.Size = new System.Drawing.Size(280, 403);
            this.listviewDisplaybox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.listviewDisplaybox, "Data from two sensors");
            this.listviewDisplaybox.UseCompatibleStateImageBehavior = false;
            this.listviewDisplaybox.View = System.Windows.Forms.View.Details;
            // 
            // columnSensorA
            // 
            this.columnSensorA.Text = "Sensor A";
            this.columnSensorA.Width = 95;
            // 
            // columnSensorB
            // 
            this.columnSensorB.Text = "Sensor B";
            this.columnSensorB.Width = 108;
            // 
            // listBoxDisplaySensorA
            // 
            this.listBoxDisplaySensorA.FormattingEnabled = true;
            this.listBoxDisplaySensorA.ItemHeight = 16;
            this.listBoxDisplaySensorA.Location = new System.Drawing.Point(521, 38);
            this.listBoxDisplaySensorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDisplaySensorA.Name = "listBoxDisplaySensorA";
            this.listBoxDisplaySensorA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDisplaySensorA.Size = new System.Drawing.Size(148, 420);
            this.listBoxDisplaySensorA.TabIndex = 6;
            this.toolTip1.SetToolTip(this.listBoxDisplaySensorA, "Sensor A data");
            // 
            // listBoxDisplaySensorB
            // 
            this.listBoxDisplaySensorB.FormattingEnabled = true;
            this.listBoxDisplaySensorB.ItemHeight = 16;
            this.listBoxDisplaySensorB.Location = new System.Drawing.Point(864, 36);
            this.listBoxDisplaySensorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDisplaySensorB.Name = "listBoxDisplaySensorB";
            this.listBoxDisplaySensorB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDisplaySensorB.Size = new System.Drawing.Size(145, 420);
            this.listBoxDisplaySensorB.TabIndex = 7;
            this.toolTip1.SetToolTip(this.listBoxDisplaySensorB, "Sensor B data");
            // 
            // sigmaNumericUpDown
            // 
            this.sigmaNumericUpDown.Location = new System.Drawing.Point(24, 30);
            this.sigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sigmaNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sigmaNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sigmaNumericUpDown.Name = "sigmaNumericUpDown";
            this.sigmaNumericUpDown.Size = new System.Drawing.Size(132, 22);
            this.sigmaNumericUpDown.TabIndex = 8;
            this.toolTip1.SetToolTip(this.sigmaNumericUpDown, "Min value: 10, Max value: 20");
            this.sigmaNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // muNumericUpDown
            // 
            this.muNumericUpDown.Location = new System.Drawing.Point(172, 30);
            this.muNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.muNumericUpDown.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.muNumericUpDown.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.muNumericUpDown.Name = "muNumericUpDown";
            this.muNumericUpDown.Size = new System.Drawing.Size(131, 22);
            this.muNumericUpDown.TabIndex = 9;
            this.toolTip1.SetToolTip(this.muNumericUpDown, "Min value: 50, Max value: 75");
            this.muNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // iterativeSearchALabel
            // 
            this.iterativeSearchALabel.AutoSize = true;
            this.iterativeSearchALabel.Location = new System.Drawing.Point(341, 29);
            this.iterativeSearchALabel.Name = "iterativeSearchALabel";
            this.iterativeSearchALabel.Size = new System.Drawing.Size(141, 16);
            this.iterativeSearchALabel.TabIndex = 10;
            this.iterativeSearchALabel.Text = "Binary Search Iterative";
            // 
            // iterativeSearchBLabel
            // 
            this.iterativeSearchBLabel.AutoSize = true;
            this.iterativeSearchBLabel.Location = new System.Drawing.Point(693, 30);
            this.iterativeSearchBLabel.Name = "iterativeSearchBLabel";
            this.iterativeSearchBLabel.Size = new System.Drawing.Size(141, 16);
            this.iterativeSearchBLabel.TabIndex = 11;
            this.iterativeSearchBLabel.Text = "Binary Search Iterative";
            // 
            // iterativeSearchSensorABtn
            // 
            this.iterativeSearchSensorABtn.Location = new System.Drawing.Point(344, 52);
            this.iterativeSearchSensorABtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterativeSearchSensorABtn.Name = "iterativeSearchSensorABtn";
            this.iterativeSearchSensorABtn.Size = new System.Drawing.Size(144, 23);
            this.iterativeSearchSensorABtn.TabIndex = 12;
            this.iterativeSearchSensorABtn.Text = "Search";
            this.toolTip1.SetToolTip(this.iterativeSearchSensorABtn, "Search button for sensor A");
            this.iterativeSearchSensorABtn.UseVisualStyleBackColor = true;
            this.iterativeSearchSensorABtn.Click += new System.EventHandler(this.iterativeSearchSensorABtn_Click);
            // 
            // iterativeSearchSensorBBtn
            // 
            this.iterativeSearchSensorBBtn.Location = new System.Drawing.Point(692, 53);
            this.iterativeSearchSensorBBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterativeSearchSensorBBtn.Name = "iterativeSearchSensorBBtn";
            this.iterativeSearchSensorBBtn.Size = new System.Drawing.Size(141, 23);
            this.iterativeSearchSensorBBtn.TabIndex = 13;
            this.iterativeSearchSensorBBtn.Text = "Search";
            this.toolTip1.SetToolTip(this.iterativeSearchSensorBBtn, "Search button for sensor B");
            this.iterativeSearchSensorBBtn.UseVisualStyleBackColor = true;
            this.iterativeSearchSensorBBtn.Click += new System.EventHandler(this.iterativeSearchSensorBBtn_Click);
            // 
            // textboxIterativeSensorA
            // 
            this.textboxIterativeSensorA.Location = new System.Drawing.Point(344, 80);
            this.textboxIterativeSensorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxIterativeSensorA.Name = "textboxIterativeSensorA";
            this.textboxIterativeSensorA.ReadOnly = true;
            this.textboxIterativeSensorA.Size = new System.Drawing.Size(144, 22);
            this.textboxIterativeSensorA.TabIndex = 14;
            this.textboxIterativeSensorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // textboxIterativeSearchB
            // 
            this.textboxIterativeSearchB.Location = new System.Drawing.Point(692, 82);
            this.textboxIterativeSearchB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxIterativeSearchB.Name = "textboxIterativeSearchB";
            this.textboxIterativeSearchB.ReadOnly = true;
            this.textboxIterativeSearchB.Size = new System.Drawing.Size(144, 22);
            this.textboxIterativeSearchB.TabIndex = 15;
            this.textboxIterativeSearchB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // textboxRecursiveSensorA
            // 
            this.textboxRecursiveSensorA.Location = new System.Drawing.Point(344, 177);
            this.textboxRecursiveSensorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxRecursiveSensorA.Name = "textboxRecursiveSensorA";
            this.textboxRecursiveSensorA.ReadOnly = true;
            this.textboxRecursiveSensorA.Size = new System.Drawing.Size(144, 22);
            this.textboxRecursiveSensorA.TabIndex = 18;
            this.textboxRecursiveSensorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // recusiveSearchSensorABtn
            // 
            this.recusiveSearchSensorABtn.Location = new System.Drawing.Point(344, 149);
            this.recusiveSearchSensorABtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recusiveSearchSensorABtn.Name = "recusiveSearchSensorABtn";
            this.recusiveSearchSensorABtn.Size = new System.Drawing.Size(144, 23);
            this.recusiveSearchSensorABtn.TabIndex = 17;
            this.recusiveSearchSensorABtn.Text = "Search";
            this.toolTip1.SetToolTip(this.recusiveSearchSensorABtn, "Search button for sensor A");
            this.recusiveSearchSensorABtn.UseVisualStyleBackColor = true;
            this.recusiveSearchSensorABtn.Click += new System.EventHandler(this.recusiveSearchSensorABtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Binary Search Recursive";
            // 
            // textboxRecursiveSensorB
            // 
            this.textboxRecursiveSensorB.Location = new System.Drawing.Point(696, 178);
            this.textboxRecursiveSensorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxRecursiveSensorB.Name = "textboxRecursiveSensorB";
            this.textboxRecursiveSensorB.ReadOnly = true;
            this.textboxRecursiveSensorB.Size = new System.Drawing.Size(144, 22);
            this.textboxRecursiveSensorB.TabIndex = 21;
            this.textboxRecursiveSensorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // recursiveSearchSensorBBtn
            // 
            this.recursiveSearchSensorBBtn.Location = new System.Drawing.Point(696, 149);
            this.recursiveSearchSensorBBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recursiveSearchSensorBBtn.Name = "recursiveSearchSensorBBtn";
            this.recursiveSearchSensorBBtn.Size = new System.Drawing.Size(144, 23);
            this.recursiveSearchSensorBBtn.TabIndex = 20;
            this.recursiveSearchSensorBBtn.Text = "Search";
            this.toolTip1.SetToolTip(this.recursiveSearchSensorBBtn, "Search button for sensor B");
            this.recursiveSearchSensorBBtn.UseVisualStyleBackColor = true;
            this.recursiveSearchSensorBBtn.Click += new System.EventHandler(this.recursiveSearchSensorBBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Binary Search Recursive";
            // 
            // textboxSelectionSortSensorA
            // 
            this.textboxSelectionSortSensorA.Location = new System.Drawing.Point(344, 349);
            this.textboxSelectionSortSensorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxSelectionSortSensorA.Name = "textboxSelectionSortSensorA";
            this.textboxSelectionSortSensorA.ReadOnly = true;
            this.textboxSelectionSortSensorA.Size = new System.Drawing.Size(144, 22);
            this.textboxSelectionSortSensorA.TabIndex = 24;
            this.textboxSelectionSortSensorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // selectionSortSensorABtn
            // 
            this.selectionSortSensorABtn.Location = new System.Drawing.Point(344, 319);
            this.selectionSortSensorABtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionSortSensorABtn.Name = "selectionSortSensorABtn";
            this.selectionSortSensorABtn.Size = new System.Drawing.Size(144, 23);
            this.selectionSortSensorABtn.TabIndex = 23;
            this.selectionSortSensorABtn.Text = "Sort";
            this.toolTip1.SetToolTip(this.selectionSortSensorABtn, "Selection sort for sensor A");
            this.selectionSortSensorABtn.UseVisualStyleBackColor = true;
            this.selectionSortSensorABtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectionSortSensorABtn_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Selection Sort";
            // 
            // textboxSelectionSortSensorB
            // 
            this.textboxSelectionSortSensorB.Location = new System.Drawing.Point(695, 352);
            this.textboxSelectionSortSensorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxSelectionSortSensorB.Name = "textboxSelectionSortSensorB";
            this.textboxSelectionSortSensorB.ReadOnly = true;
            this.textboxSelectionSortSensorB.Size = new System.Drawing.Size(144, 22);
            this.textboxSelectionSortSensorB.TabIndex = 27;
            this.textboxSelectionSortSensorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // selectionSortSensorBBtn
            // 
            this.selectionSortSensorBBtn.Location = new System.Drawing.Point(695, 323);
            this.selectionSortSensorBBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionSortSensorBBtn.Name = "selectionSortSensorBBtn";
            this.selectionSortSensorBBtn.Size = new System.Drawing.Size(144, 23);
            this.selectionSortSensorBBtn.TabIndex = 26;
            this.selectionSortSensorBBtn.Text = "Sort";
            this.toolTip1.SetToolTip(this.selectionSortSensorBBtn, "Selection sort for sensor B");
            this.selectionSortSensorBBtn.UseVisualStyleBackColor = true;
            this.selectionSortSensorBBtn.Click += new System.EventHandler(this.selectionSortSensorBBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Selection Sort";
            // 
            // textboxInsertionSensorA
            // 
            this.textboxInsertionSensorA.Location = new System.Drawing.Point(344, 433);
            this.textboxInsertionSensorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxInsertionSensorA.Name = "textboxInsertionSensorA";
            this.textboxInsertionSensorA.ReadOnly = true;
            this.textboxInsertionSensorA.Size = new System.Drawing.Size(144, 22);
            this.textboxInsertionSensorA.TabIndex = 30;
            this.textboxInsertionSensorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // insertionSortSensorABtn
            // 
            this.insertionSortSensorABtn.Location = new System.Drawing.Point(344, 405);
            this.insertionSortSensorABtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertionSortSensorABtn.Name = "insertionSortSensorABtn";
            this.insertionSortSensorABtn.Size = new System.Drawing.Size(144, 23);
            this.insertionSortSensorABtn.TabIndex = 29;
            this.insertionSortSensorABtn.Text = "Sort";
            this.toolTip1.SetToolTip(this.insertionSortSensorABtn, "Insertion sort for sensor A");
            this.insertionSortSensorABtn.UseVisualStyleBackColor = true;
            this.insertionSortSensorABtn.Click += new System.EventHandler(this.insertionSortSensorABtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Insertion Sort";
            // 
            // textboxInsertionSensorB
            // 
            this.textboxInsertionSensorB.Location = new System.Drawing.Point(695, 432);
            this.textboxInsertionSensorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxInsertionSensorB.Name = "textboxInsertionSensorB";
            this.textboxInsertionSensorB.ReadOnly = true;
            this.textboxInsertionSensorB.Size = new System.Drawing.Size(144, 22);
            this.textboxInsertionSensorB.TabIndex = 33;
            this.textboxInsertionSensorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // insertionSortSensorBBtn
            // 
            this.insertionSortSensorBBtn.Location = new System.Drawing.Point(695, 404);
            this.insertionSortSensorBBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertionSortSensorBBtn.Name = "insertionSortSensorBBtn";
            this.insertionSortSensorBBtn.Size = new System.Drawing.Size(144, 23);
            this.insertionSortSensorBBtn.TabIndex = 32;
            this.insertionSortSensorBBtn.Text = "Sort";
            this.toolTip1.SetToolTip(this.insertionSortSensorBBtn, "Insertion sort for sensor B");
            this.insertionSortSensorBBtn.UseVisualStyleBackColor = true;
            this.insertionSortSensorBBtn.Click += new System.EventHandler(this.insertionSortSensorBBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(692, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Insertion Sort";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Search Target";
            // 
            // textBoxSearchTargetA
            // 
            this.textBoxSearchTargetA.Location = new System.Drawing.Point(344, 249);
            this.textBoxSearchTargetA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchTargetA.Name = "textBoxSearchTargetA";
            this.textBoxSearchTargetA.Size = new System.Drawing.Size(89, 22);
            this.textBoxSearchTargetA.TabIndex = 35;
            this.toolTip1.SetToolTip(this.textBoxSearchTargetA, "Enter a value to search");
            this.textBoxSearchTargetA.Click += new System.EventHandler(this.textBoxSearchTargetA_Click);
            this.textBoxSearchTargetA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // textBoxSearchTargetB
            // 
            this.textBoxSearchTargetB.Location = new System.Drawing.Point(692, 250);
            this.textBoxSearchTargetB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchTargetB.Name = "textBoxSearchTargetB";
            this.textBoxSearchTargetB.Size = new System.Drawing.Size(89, 22);
            this.textBoxSearchTargetB.TabIndex = 37;
            this.toolTip1.SetToolTip(this.textBoxSearchTargetB, "Enter a value to search");
            this.textBoxSearchTargetB.Click += new System.EventHandler(this.textBoxSearchTargetB_Click);
            this.textBoxSearchTargetB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(689, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Search Target";
            // 
            // ClearAllTextBoxesButton
            // 
            this.ClearAllTextBoxesButton.Location = new System.Drawing.Point(521, 463);
            this.ClearAllTextBoxesButton.Name = "ClearAllTextBoxesButton";
            this.ClearAllTextBoxesButton.Size = new System.Drawing.Size(488, 36);
            this.ClearAllTextBoxesButton.TabIndex = 38;
            this.ClearAllTextBoxesButton.Text = "Clear All Textboxes";
            this.ClearAllTextBoxesButton.UseVisualStyleBackColor = true;
            this.ClearAllTextBoxesButton.Click += new System.EventHandler(this.ClearAllTextBoxesButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1025, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // MalinSpaceSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ClearAllTextBoxesButton);
            this.Controls.Add(this.textBoxSearchTargetB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSearchTargetA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textboxInsertionSensorB);
            this.Controls.Add(this.insertionSortSensorBBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textboxInsertionSensorA);
            this.Controls.Add(this.insertionSortSensorABtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textboxSelectionSortSensorB);
            this.Controls.Add(this.selectionSortSensorBBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxSelectionSortSensorA);
            this.Controls.Add(this.selectionSortSensorABtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxRecursiveSensorB);
            this.Controls.Add(this.recursiveSearchSensorBBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxRecursiveSensorA);
            this.Controls.Add(this.recusiveSearchSensorABtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxIterativeSearchB);
            this.Controls.Add(this.textboxIterativeSensorA);
            this.Controls.Add(this.iterativeSearchSensorBBtn);
            this.Controls.Add(this.iterativeSearchSensorABtn);
            this.Controls.Add(this.iterativeSearchBLabel);
            this.Controls.Add(this.iterativeSearchALabel);
            this.Controls.Add(this.muNumericUpDown);
            this.Controls.Add(this.sigmaNumericUpDown);
            this.Controls.Add(this.listBoxDisplaySensorB);
            this.Controls.Add(this.listBoxDisplaySensorA);
            this.Controls.Add(this.listviewDisplaybox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadSensorDataButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MalinSpaceSensors";
            this.Text = "Malin Space Systems Data Processing";
            this.Click += new System.EventHandler(this.MalinSpaceSensors_Click);
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadSensorDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listviewDisplaybox;
        private System.Windows.Forms.ColumnHeader columnSensorA;
        private System.Windows.Forms.ColumnHeader columnSensorB;
        private System.Windows.Forms.ListBox listBoxDisplaySensorA;
        private System.Windows.Forms.ListBox listBoxDisplaySensorB;
        private System.Windows.Forms.NumericUpDown sigmaNumericUpDown;
        private System.Windows.Forms.NumericUpDown muNumericUpDown;
        private System.Windows.Forms.Label iterativeSearchALabel;
        private System.Windows.Forms.Label iterativeSearchBLabel;
        private System.Windows.Forms.Button iterativeSearchSensorABtn;
        private System.Windows.Forms.Button iterativeSearchSensorBBtn;
        private System.Windows.Forms.TextBox textboxIterativeSensorA;
        private System.Windows.Forms.TextBox textboxIterativeSearchB;
        private System.Windows.Forms.TextBox textboxRecursiveSensorA;
        private System.Windows.Forms.Button recusiveSearchSensorABtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxRecursiveSensorB;
        private System.Windows.Forms.Button recursiveSearchSensorBBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxSelectionSortSensorA;
        private System.Windows.Forms.Button selectionSortSensorABtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxSelectionSortSensorB;
        private System.Windows.Forms.Button selectionSortSensorBBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textboxInsertionSensorA;
        private System.Windows.Forms.Button insertionSortSensorABtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textboxInsertionSensorB;
        private System.Windows.Forms.Button insertionSortSensorBBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSearchTargetA;
        private System.Windows.Forms.TextBox textBoxSearchTargetB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ClearAllTextBoxesButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

