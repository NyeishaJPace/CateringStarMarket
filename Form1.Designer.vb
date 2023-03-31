<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.radGourmetCheese = New System.Windows.Forms.RadioButton()
        Me.radPinwheelWraps = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radSausageCheese = New System.Windows.Forms.RadioButton()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radPayUponPickup = New System.Windows.Forms.RadioButton()
        Me.txtLoyaltyPoints = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPaymentInformation = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(428, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'radGourmetCheese
        '
        Me.radGourmetCheese.AutoSize = True
        Me.radGourmetCheese.BackColor = System.Drawing.Color.PapayaWhip
        Me.radGourmetCheese.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGourmetCheese.Location = New System.Drawing.Point(6, 9)
        Me.radGourmetCheese.Name = "radGourmetCheese"
        Me.radGourmetCheese.Size = New System.Drawing.Size(194, 20)
        Me.radGourmetCheese.TabIndex = 2
        Me.radGourmetCheese.TabStop = True
        Me.radGourmetCheese.Text = "Gourmet Cheese $49.99"
        Me.radGourmetCheese.UseVisualStyleBackColor = False
        '
        'radPinwheelWraps
        '
        Me.radPinwheelWraps.AutoSize = True
        Me.radPinwheelWraps.BackColor = System.Drawing.Color.PapayaWhip
        Me.radPinwheelWraps.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPinwheelWraps.Location = New System.Drawing.Point(6, 46)
        Me.radPinwheelWraps.Name = "radPinwheelWraps"
        Me.radPinwheelWraps.Size = New System.Drawing.Size(194, 20)
        Me.radPinwheelWraps.TabIndex = 3
        Me.radPinwheelWraps.TabStop = True
        Me.radPinwheelWraps.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheelWraps.UseVisualStyleBackColor = False
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.BackColor = System.Drawing.Color.PapayaWhip
        Me.radVeggie.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVeggie.Location = New System.Drawing.Point(6, 83)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(130, 20)
        Me.radVeggie.TabIndex = 4
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = False
        '
        'radSausageCheese
        '
        Me.radSausageCheese.AutoSize = True
        Me.radSausageCheese.BackColor = System.Drawing.Color.PapayaWhip
        Me.radSausageCheese.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSausageCheese.Location = New System.Drawing.Point(6, 120)
        Me.radSausageCheese.Name = "radSausageCheese"
        Me.radSausageCheese.Size = New System.Drawing.Size(226, 20)
        Me.radSausageCheese.TabIndex = 5
        Me.radSausageCheese.TabStop = True
        Me.radSausageCheese.Text = "Sausage and Cheese $49.99"
        Me.radSausageCheese.UseVisualStyleBackColor = False
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.BackColor = System.Drawing.Color.PapayaWhip
        Me.radFruit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFruit.Location = New System.Drawing.Point(6, 158)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(122, 20)
        Me.radFruit.TabIndex = 6
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = False
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.BackColor = System.Drawing.Color.PapayaWhip
        Me.radPrePay.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(4, 19)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(82, 20)
        Me.radPrePay.TabIndex = 8
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = False
        '
        'radPayUponPickup
        '
        Me.radPayUponPickup.AutoSize = True
        Me.radPayUponPickup.BackColor = System.Drawing.Color.PapayaWhip
        Me.radPayUponPickup.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPayUponPickup.Location = New System.Drawing.Point(4, 51)
        Me.radPayUponPickup.Name = "radPayUponPickup"
        Me.radPayUponPickup.Size = New System.Drawing.Size(146, 20)
        Me.radPayUponPickup.TabIndex = 9
        Me.radPayUponPickup.TabStop = True
        Me.radPayUponPickup.Text = "Pay upon Pickup"
        Me.radPayUponPickup.UseVisualStyleBackColor = False
        '
        'txtLoyaltyPoints
        '
        Me.txtLoyaltyPoints.Location = New System.Drawing.Point(639, 307)
        Me.txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        Me.txtLoyaltyPoints.Size = New System.Drawing.Size(71, 20)
        Me.txtLoyaltyPoints.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Please Pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(485, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Loyalty Points"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(468, 371)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 33)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(657, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 33)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 64)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Catering " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Star Market"
        '
        'lblPaymentInformation
        '
        Me.lblPaymentInformation.AutoSize = True
        Me.lblPaymentInformation.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentInformation.Location = New System.Drawing.Point(211, 457)
        Me.lblPaymentInformation.Name = "lblPaymentInformation"
        Me.lblPaymentInformation.Size = New System.Drawing.Size(70, 23)
        Me.lblPaymentInformation.TabIndex = 16
        Me.lblPaymentInformation.Text = "Label4"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.GroupBox1.Controls.Add(Me.radGourmetCheese)
        Me.GroupBox1.Controls.Add(Me.radPinwheelWraps)
        Me.GroupBox1.Controls.Add(Me.radVeggie)
        Me.GroupBox1.Controls.Add(Me.radSausageCheese)
        Me.GroupBox1.Controls.Add(Me.radFruit)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 202)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PapayaWhip
        Me.GroupBox2.Controls.Add(Me.radPrePay)
        Me.GroupBox2.Controls.Add(Me.radPayUponPickup)
        Me.GroupBox2.Location = New System.Drawing.Point(99, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 92)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPaymentInformation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLoyaltyPoints)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents radGourmetCheese As RadioButton
    Friend WithEvents radPinwheelWraps As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radSausageCheese As RadioButton
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents radPayUponPickup As RadioButton
    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPaymentInformation As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
