VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Main Form"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.OptionButton RadioButton2 
      Caption         =   "C++"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3360
      TabIndex        =   7
      Top             =   2400
      Width           =   855
   End
   Begin VB.OptionButton RadioButton1 
      Caption         =   "C#"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2160
      TabIndex        =   6
      Top             =   2400
      Width           =   855
   End
   Begin VB.CommandButton btnCancel 
      Caption         =   "Cancel"
      Height          =   255
      Left            =   1920
      TabIndex        =   5
      Top             =   1560
      Width           =   615
   End
   Begin VB.CommandButton btnOK 
      Caption         =   "OK"
      Height          =   255
      Left            =   2880
      TabIndex        =   4
      Top             =   1560
      Width           =   615
   End
   Begin VB.TextBox txbPassword 
      Height          =   375
      Left            =   1560
      TabIndex        =   1
      Top             =   960
      Width           =   1935
   End
   Begin VB.TextBox txbLogin 
      Height          =   375
      Left            =   1560
      TabIndex        =   0
      Top             =   360
      Width           =   1935
   End
   Begin VB.Label lblPassword 
      Caption         =   "Password"
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   960
      Width           =   975
   End
   Begin VB.Label lblLogin 
      Caption         =   "Login"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   360
      Width           =   975
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim aConnection As New ADODB.Connection
Dim aRecSet As New ADODB.Recordset


Private Sub btnCancel_Click()
Unload Me
End Sub

Private Sub btnOK_Click()

 Dim parLogin As String
 Dim parPassword As String
 
 parLogin = txbLogin.Text
 parPassword = txbPassword.Text
 

 Set cmd = New ADODB.Command
 cmd.ActiveConnection = aConnection
 cmd.CommandType = adCmdStoredProc
 cmd.CommandText = "Verification"

 cmd.Parameters.Append cmd.CreateParameter _
 ("Login", adVarChar, adParamInput, 30, parLogin)
 cmd.Parameters.Append cmd.CreateParameter _
    ("Username", adVarChar, adParamInput, 30, parPassword)
  Set aRecSet = cmd.Execute

 Dim ID As Integer
 If Not aRecSet.EOF Then
 ID = aRecSet.Fields("ID").Value
 RadioButton1.Enabled = True
 RadioButton2.Enabled = True
 Else
 MsgBox "Failed!", vbDefaultButton1, "Exception"
 End If
 Set cmd.ActiveConnection = Nothing
  End Sub
  

Private Sub Form_Load()
aConnection.Open _
"Provider=sqloledb;" & _
"Data Source=localhost;" & _
"Initial Catalog=InteropTasks;" & _
"Trusted_Connection=yes;"
End Sub

Private Sub Form_Unload(Cancel As Integer)
aConnection.Close
End Sub


Private Sub RadioButton1_Click()
 Dim v As New InteropTask1_Net.Class1
  v.func (WinForm_Main)
End Sub

Private Sub RadioButton2_Click()
Dim f As New COMCLib.InteropTask
 f.Call
End Sub
