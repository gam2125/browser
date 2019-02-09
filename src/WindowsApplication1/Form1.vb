Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CefSharp
Imports CefSharp.WinForms


Namespace SharpBrowser



    Partial Public Class Form1
        Inherits Form





        Public browser As ChromiumWebBrowser
        Public Sub InitBrowser()
            Cef.Initialize(New CefSettings())
            browser = New ChromiumWebBrowser("www.google.com")
            Me.Controls.Add(browser)
            browser.Dock = DockStyle.Fill
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            InitBrowser()
        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(284, 261)
            Me.Name = "Form1"
            Me.ResumeLayout(False)

        End Sub

        Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace


