using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace orderformcalculator
{
/// <summary>
/// Summary description for OrderFormCalculator form
/// </summary>
public class OrderFormCalculator : System.Windows.Forms.Form
{
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.Button btnCalculate;
private System.Windows.Forms.Button btnExit;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.Button btnClear;
private System.Windows.Forms.Button btnHelp;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.TextBox textShipPcnt;
private System.Windows.Forms.TextBox textShipCost;
private System.Windows.Forms.Label label6;
private System.Windows.Forms.TextBox textItmQty;
private System.Windows.Forms.TextBox textPurchTotal;
private System.Windows.Forms.GroupBox groupBox1;
private System.Windows.Forms.RadioButton radBtn1;
private System.Windows.Forms.RadioButton radBtn2;
private System.Windows.Forms.RadioButton radBtn3;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.TextBox textItmEach;
private System.Windows.Forms.TextBox textItmTotal;
private System.Windows.Forms.ComboBox cboItmPrices;

/// <summary>
/// Required designer variable
/// </summary>
private System.ComponentModel.Container components = null;

public OrderFormCalculator()
{
//
// Required for Windows Form Designer support
//
InitializeComponent();

//
// TODO: Add any constructor code after InitializeComponent call
//
}

/// <summary>
/// Clean up any resources being used
/// </summary>
protected override void Dispose( bool disposing )
{
if( disposing )
{
if (components != null)
{
components.Dispose();
}
}
base.Dispose( disposing );
}

#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor
/// </summary>
private void InitializeComponent()
{
            this.cboItmPrices = new System.Windows.Forms.ComboBox();
            this.textItmQty = new System.Windows.Forms.TextBox();
            this.textItmEach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textItmTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textShipPcnt = new System.Windows.Forms.TextBox();
            this.textShipCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPurchTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radBtn3 = new System.Windows.Forms.RadioButton();
            this.radBtn2 = new System.Windows.Forms.RadioButton();
            this.radBtn1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboItmPrices
            // 
            this.cboItmPrices.Items.AddRange(new object[] {
            "Choose a Bag Type:",
            "Full Decorative $50",
            "Beaded $45",
            "Needlepoint $40",
            "Fringed $25",
            "Fringed Beaded $50",
            "Plain $20"});
            this.cboItmPrices.Location = new System.Drawing.Point(16, 34);
            this.cboItmPrices.Name = "cboItmPrices";
            this.cboItmPrices.Size = new System.Drawing.Size(128, 21);
            this.cboItmPrices.TabIndex = 0;
            this.cboItmPrices.SelectedIndexChanged += new System.EventHandler(this.cboItmPrices_SelectedIndexChanged);
            // 
            // textItmQty
            // 
            this.textItmQty.Location = new System.Drawing.Point(168, 34);
            this.textItmQty.Name = "textItmQty";
            this.textItmQty.Size = new System.Drawing.Size(48, 20);
            this.textItmQty.TabIndex = 1;
            this.textItmQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textItmEach
            // 
            this.textItmEach.Location = new System.Drawing.Point(232, 34);
            this.textItmEach.Name = "textItmEach";
            this.textItmEach.ReadOnly = true;
            this.textItmEach.Size = new System.Drawing.Size(72, 20);
            this.textItmEach.TabIndex = 2;
            this.textItmEach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(160, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(232, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Each";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(216, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 24);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(312, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(320, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textItmTotal
            // 
            this.textItmTotal.Location = new System.Drawing.Point(320, 34);
            this.textItmTotal.Name = "textItmTotal";
            this.textItmTotal.ReadOnly = true;
            this.textItmTotal.Size = new System.Drawing.Size(72, 20);
            this.textItmTotal.TabIndex = 9;
            this.textItmTotal.TabStop = false;
            this.textItmTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bag Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(120, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 24);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(24, 144);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(80, 24);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(176, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Shipping Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textShipPcnt
            // 
            this.textShipPcnt.Location = new System.Drawing.Point(264, 64);
            this.textShipPcnt.Name = "textShipPcnt";
            this.textShipPcnt.ReadOnly = true;
            this.textShipPcnt.Size = new System.Drawing.Size(40, 20);
            this.textShipPcnt.TabIndex = 17;
            this.textShipPcnt.TabStop = false;
            this.textShipPcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textShipCost
            // 
            this.textShipCost.Location = new System.Drawing.Point(320, 64);
            this.textShipCost.Name = "textShipCost";
            this.textShipCost.ReadOnly = true;
            this.textShipCost.Size = new System.Drawing.Size(72, 20);
            this.textShipCost.TabIndex = 18;
            this.textShipCost.TabStop = false;
            this.textShipCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(232, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Purchase";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPurchTotal
            // 
            this.textPurchTotal.Location = new System.Drawing.Point(320, 96);
            this.textPurchTotal.Name = "textPurchTotal";
            this.textPurchTotal.ReadOnly = true;
            this.textPurchTotal.Size = new System.Drawing.Size(72, 20);
            this.textPurchTotal.TabIndex = 20;
            this.textPurchTotal.TabStop = false;
            this.textPurchTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radBtn3);
            this.groupBox1.Controls.Add(this.radBtn2);
            this.groupBox1.Controls.Add(this.radBtn1);
            this.groupBox1.Location = new System.Drawing.Point(8, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 80);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(18, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Shipping Type:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radBtn3
            // 
            this.radBtn3.Checked = true;
            this.radBtn3.Location = new System.Drawing.Point(16, 56);
            this.radBtn3.Name = "radBtn3";
            this.radBtn3.Size = new System.Drawing.Size(104, 18);
            this.radBtn3.TabIndex = 2;
            this.radBtn3.TabStop = true;
            this.radBtn3.Text = "Standard (5%)";
            // 
            // radBtn2
            // 
            this.radBtn2.Location = new System.Drawing.Point(16, 40);
            this.radBtn2.Name = "radBtn2";
            this.radBtn2.Size = new System.Drawing.Size(104, 18);
            this.radBtn2.TabIndex = 1;
            this.radBtn2.Text = "3 Day (7%)";
            // 
            // radBtn1
            // 
            this.radBtn1.Location = new System.Drawing.Point(16, 24);
            this.radBtn1.Name = "radBtn1";
            this.radBtn1.Size = new System.Drawing.Size(112, 18);
            this.radBtn1.TabIndex = 0;
            this.radBtn1.Text = "Overnight (10%)";
            // 
            // OrderFormCalculator
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(416, 190);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPurchTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textShipCost);
            this.Controls.Add(this.textShipPcnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textItmTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textItmEach);
            this.Controls.Add(this.textItmQty);
            this.Controls.Add(this.cboItmPrices);
            this.Name = "OrderFormCalculator";
            this.Text = "Order Form Calculator";
            this.Load += new System.EventHandler(this.OrderFormCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

}
#endregion

/// <summary>
/// The main entry point for the application
/// </summary>
[STAThread]
static void Main()
{
Application.Run(new OrderFormCalculator());
}

// Form load event
// Initialize the screen controls
private void OrderFormCalculator_Load(object sender, System.EventArgs e)
{
InitScreenControls();
}

// "Help" button event
// The user has clicked on the "Help" button
// Display user help information
private void btnHelp_Click(object sender, System.EventArgs e)
{
string helpinfo = "";
helpinfo += " User Instructions:\n\n";
helpinfo += "1. Choose a Bag Type.\n";
helpinfo += "2. Enter a Quantity, 1 to 100 (if other than 1).\n";
helpinfo += "3. Click on Calculate.\n";
helpinfo += "4. View Shipping Cost and Total Purchase.\n";
helpinfo += "5. If Quantity is changed, click on Calculate again.\n";
helpinfo += "6. If Shipping Type is changed, click on Calculate again.\n\n";
helpinfo += " Thank You for Your Purchase!\n";
MessageBox.Show(helpinfo, "Order Form Calculator Help",
MessageBoxButtons.OK, MessageBoxIcon.Information,
MessageBoxDefaultButton.Button1);
}

// "Clear" button event
// The user has clicked on the "Clear" button
// Initialize the screen controls
private void btnClear_Click(object sender, System.EventArgs e)
{
InitScreenControls();
}

// Initialize the screen controls
private void InitScreenControls()
{
cboItmPrices.SelectedIndex = 0; // set combo box = "Choose a Bag Type:"
textItmQty.Text = ""; // initialize "item qty" to a null string
InitScreenControls2(); // initialize text box controls to null strings
radBtn3.Checked = true; // set default "shipping type" = standard
}

// Initialize text box controls
private void InitScreenControls2()
{
textItmEach.Text = "";
textItmTotal.Text = "";
textShipPcnt.Text = "";
textShipCost.Text = "";
textPurchTotal.Text = "";
}

// "Calculate" button event
// The user has clicked on the "Calculate" button
// so calculate the Each, Total extended item values, and
// calculate the Shipping Pcnt and Shipping Cost values, and
// calculate the Total Purchase value.
// Then display the calculated values on the form
// and also in a MessageBox.
private void btnCalculate_Click(object sender, System.EventArgs e)
{
InitScreenControls2();

string strItmPrice = "";
string strItmQty = "";
string strShipPcnt = "";

double dblItmPrice = 0;
int intItmQty = 0;
double dblItmEach = 0;
double dblItmTotal = 0;
double dblShipPcnt = 0;
double dblShipCost = 0;
double dblPurchTotal = 0;
int intShipIndex = 0;

bool inperror = false;

// extract the "item price" value as right-most two characters
// of selected combo box item, such as "20" from "Plain $20", etc.
string strItm = cboItmPrices.SelectedItem.ToString();
int lenItm = strItm.Length;
strItmPrice = strItm.Substring(lenItm - 2, 2);

// fetch the "item quantity" value from input text box
strItmQty = textItmQty.Text;

// convert the "item price" string to double
try
{
dblItmPrice = double.Parse(strItmPrice);
dblItmEach = dblItmPrice;
}
catch
{
string helpinfo = "Bag Type: Please choose an item.";
MessageBox.Show(helpinfo, "Bad Input Data",
MessageBoxButtons.OK, MessageBoxIcon.Error,
MessageBoxDefaultButton.Button1);
cboItmPrices.SelectedIndex = 0;
cboItmPrices.Focus();
inperror = true;
}

// convert the "item quantity" string to an integer
try
{
intItmQty = int.Parse(strItmQty);
}
catch
{
if (!inperror)
{
string helpinfo = "Quantity: Please enter an integer value (1 to 100).";
MessageBox.Show(helpinfo, "Bad Input Data",
MessageBoxButtons.OK, MessageBoxIcon.Error,
MessageBoxDefaultButton.Button1);
textItmQty.Focus();
}

inperror = true;
}

// check for "item quantity" value in the integer range 1 to 100
if (!inperror)
{
if((intItmQty < 1) || (intItmQty > 100))
{
string helpinfo = "Quantity: Please enter an integer value (1 to 100).";
MessageBox.Show(helpinfo, "Bad Input Data",
MessageBoxButtons.OK, MessageBoxIcon.Error,
MessageBoxDefaultButton.Button1);
textItmQty.Focus();
inperror = true;
}
}

// determine which "shipping type" radio button is checked, where
// radBtn1 = Overnight (10%)
// radBtn2 = 3 Day (7%)
// radBtn3 = Standard (5%)
intShipIndex = 0;
if (radBtn1.Checked)
{
intShipIndex = 1;
strShipPcnt = "10%";
dblShipPcnt = 0.10;
}
if (radBtn2.Checked)
{
intShipIndex = 2;
strShipPcnt = "7%";
dblShipPcnt = 0.07;
}
if (radBtn3.Checked)
{
intShipIndex = 3;
strShipPcnt = "5%";
dblShipPcnt = 0.05;
}

if (intShipIndex == 0)
{
if (!inperror)
{
string helpinfo = "Shipping: Please choose a Shipping Type.";
MessageBox.Show(helpinfo, "Bad Input Data",
MessageBoxButtons.OK, MessageBoxIcon.Error,
MessageBoxDefaultButton.Button1);
}

inperror = true;
}

// if input data is ok, then calculate and display
// the Order Form results now
if (!inperror)
{
dblItmTotal = dblItmEach * intItmQty;
dblItmTotal = Math.Round(dblItmTotal, 2);

dblShipCost = dblShipPcnt * dblItmTotal;
dblShipCost = Math.Round(dblShipCost, 2);

dblPurchTotal = dblItmTotal + dblShipCost;
dblPurchTotal = Math.Round(dblPurchTotal, 2);

textItmQty.Text = intItmQty.ToString();
textItmEach.Text = dblItmEach.ToString("c");
textItmTotal.Text = dblItmTotal.ToString("c");

textShipPcnt.Text = strShipPcnt;
textShipCost.Text = dblShipCost.ToString("c");

textPurchTotal.Text = dblPurchTotal.ToString("c");

// Display the Order Form results in a MessageBox
string msginfo = "";
msginfo += "Bag Type: " + strItm + "\n";
msginfo += "Quantity: " + strItmQty + "\n";
msginfo += "Extended Total: " + textItmTotal.Text + "\n";
msginfo += "Shipping Cost: " + textShipCost.Text + "\n";
msginfo += "Total Purchase: " + textPurchTotal.Text + "\n";
MessageBox.Show(msginfo, "Order Form Results",
MessageBoxButtons.OK, MessageBoxIcon.Information,
MessageBoxDefaultButton.Button1);
}
}

// "ItmPrices" combo-box item selected event
// When the user selects a new Bag Type, set the form "item quantity" value = 1
private void cboItmPrices_SelectedIndexChanged(object sender, System.EventArgs e)
{
textItmQty.Text = "1";
}

// "Exit" button event
// The user has clicked on the "Exit" button
// so exit from this application now.
private void btnExit_Click(object sender, System.EventArgs e)
{
this.Close();
}
}
}