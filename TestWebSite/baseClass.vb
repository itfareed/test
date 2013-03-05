Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Threading
Imports System.Globalization
Imports System.ComponentModel

Public Class baseClass
    Inherits Page

    Private bRequiredSSL As Boolean
    <Browsable(True)> _
   Public Property IsRequiredSSL() As Boolean
        Get
            Return bRequiredSSL
        End Get
        Set(ByVal value As Boolean)
            bRequiredSSL = value
        End Set
    End Property
End Class
