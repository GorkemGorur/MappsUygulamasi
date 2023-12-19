Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports GMap.NET
Imports GMap.NET.MapProviders
Public Class AnaForm
    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PRHMapKontrol.MapProvider = GMapProviders.GoogleMap
        PRHMapKontrol.Position = New PointLatLng(37.2077958, 28.3699849)
        PRHMapKontrol.MaxZoom = 24
        PRHMapKontrol.MinZoom = 1
        PRHMapKontrol.Zoom = 17

        'Haritaları ComboBox'a Yükle
        HaritaSecCBox.ValueMember = "Name"
        HaritaSecCBox.DataSource = GMapProviders.List
        HaritaSecCBox.SelectedItem = PRHMapKontrol.MapProvider

        'Zoom Nesnelerini Ayarla
        ZoomNUD.Maximum = PRHMapKontrol.MaxZoom
        ZoomPBar.Maximum = PRHMapKontrol.MaxZoom
        ZoomNUD.Minimum = PRHMapKontrol.MinZoom
        ZoomPBar.Minimum = PRHMapKontrol.MinZoom
        'Merkez İşaretini Kaldır
        PRHMapKontrol.ShowCenter = False
    End Sub

    Private Sub KonumaGitBtn_Click(sender As Object, e As EventArgs) Handles KonumaGitBtn.Click
        Dim Enlem, Boylam As Double
        If IsNumeric(EnlemTBox.Text) And IsNumeric(BoylamTBox.Text) Then
            Enlem = EnlemTBox.Text
            Boylam = BoylamTBox.Text
            PRHMapKontrol.Position = New PointLatLng(Enlem, Boylam)
        End If
    End Sub

    Private Sub HaritaSecCBox_DropDownClosed(sender As Object, e As EventArgs) Handles HaritaSecCBox.DropDownClosed
        PRHMapKontrol.MapProvider = HaritaSecCBox.SelectedItem
    End Sub

    Private Sub PRHMapKontrol_OnMapZoomChanged() Handles PRHMapKontrol.OnMapZoomChanged
        ZoomNUD.Value = PRHMapKontrol.Zoom
        ZoomPBar.Value = PRHMapKontrol.Zoom
    End Sub

    Private Sub ZoomNUD_ValueChanged(sender As Object, e As EventArgs) Handles ZoomNUD.ValueChanged
        PRHMapKontrol.Zoom = ZoomNUD.Value
    End Sub

    Private Sub AdreseGitBtn_Click(sender As Object, e As EventArgs) Handles AdreseGitBtn.Click
        Dim Konum As PointLatLng = AdresKonumuBul(AdresTBox.Text)
        If IsNothing(Konum) Then
            MessageBox.Show("Adres Bulunamadı.", "Hata")
        Else
            PRHMapKontrol.Position = Konum
        End If
    End Sub

    Private Sub PRHMapKontrol_MouseClick(sender As Object, e As MouseEventArgs) Handles PRHMapKontrol.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim Konum As PointLatLng = PRHMapKontrol.FromLocalToLatLng(e.X, e.Y)
            KonumLbl.Text = String.Format("Konum: {0} {1}", Konum.Lat, Konum.Lng)

        End If
    End Sub

    Private Function AdresKonumuBul(Adres As String) As PointLatLng
        Dim Konum As PointLatLng
        If Adres.Length > 0 Then
            Dim AdresBulmaHaritası As GeocodingProvider = GMapProviders.OpenStreetMap
            Dim Durum As GeoCoderStatusCode
            Konum = AdresBulmaHaritası.GetPoint(Adres, Durum)
            If Durum = GeoCoderStatusCode.OK Then
                Return Konum
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function
End Class
