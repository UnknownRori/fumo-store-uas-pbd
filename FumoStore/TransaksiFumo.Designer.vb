<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiFumo
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TableTransaksi = New System.Windows.Forms.DataGridView()
        Me.InJumlah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fumoComboBox = New System.Windows.Forms.ComboBox()
        Me.TotalHarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalHargaTampil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Kembalian = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TableTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KembaliToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(651, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KembaliToolStripMenuItem
        '
        Me.KembaliToolStripMenuItem.Name = "KembaliToolStripMenuItem"
        Me.KembaliToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.KembaliToolStripMenuItem.Text = "Kembali"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(288, 132)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(76, 27)
        Me.BtnHapus.TabIndex = 16
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(206, 132)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(76, 27)
        Me.BtnEdit.TabIndex = 15
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(124, 132)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(76, 27)
        Me.BtnTambah.TabIndex = 14
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TableTransaksi
        '
        Me.TableTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableTransaksi.Location = New System.Drawing.Point(12, 165)
        Me.TableTransaksi.Name = "TableTransaksi"
        Me.TableTransaksi.Size = New System.Drawing.Size(627, 267)
        Me.TableTransaksi.TabIndex = 13
        '
        'InJumlah
        '
        Me.InJumlah.Location = New System.Drawing.Point(124, 65)
        Me.InJumlah.Name = "InJumlah"
        Me.InJumlah.Size = New System.Drawing.Size(515, 20)
        Me.InJumlah.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Jumlah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fumo"
        '
        'fumoComboBox
        '
        Me.fumoComboBox.FormattingEnabled = True
        Me.fumoComboBox.Location = New System.Drawing.Point(124, 30)
        Me.fumoComboBox.Name = "fumoComboBox"
        Me.fumoComboBox.Size = New System.Drawing.Size(515, 21)
        Me.fumoComboBox.TabIndex = 17
        '
        'TotalHarga
        '
        Me.TotalHarga.Enabled = False
        Me.TotalHarga.Location = New System.Drawing.Point(124, 100)
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.ReadOnly = True
        Me.TotalHarga.Size = New System.Drawing.Size(515, 20)
        Me.TotalHarga.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total Harga"
        '
        'TotalHargaTampil
        '
        Me.TotalHargaTampil.Location = New System.Drawing.Point(124, 438)
        Me.TotalHargaTampil.Name = "TotalHargaTampil"
        Me.TotalHargaTampil.ReadOnly = True
        Me.TotalHargaTampil.Size = New System.Drawing.Size(515, 20)
        Me.TotalHargaTampil.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Total Harga"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(124, 464)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(515, 20)
        Me.TextBox3.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Bayar"
        '
        'Kembalian
        '
        Me.Kembalian.Enabled = False
        Me.Kembalian.Location = New System.Drawing.Point(124, 490)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.ReadOnly = True
        Me.Kembalian.Size = New System.Drawing.Size(515, 20)
        Me.Kembalian.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 492)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Kembalian"
        '
        'BtnCetak
        '
        Me.BtnCetak.Location = New System.Drawing.Point(124, 516)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(115, 39)
        Me.BtnCetak.TabIndex = 26
        Me.BtnCetak.Text = "Cetak"
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Location = New System.Drawing.Point(369, 132)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(76, 27)
        Me.BtnBersih.TabIndex = 27
        Me.BtnBersih.Text = "Bersih"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'TransaksiFumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 563)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotalHargaTampil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotalHarga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fumoComboBox)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TableTransaksi)
        Me.Controls.Add(Me.InJumlah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TransaksiFumo"
        Me.Text = "TransaksiFumo"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TableTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KembaliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TableTransaksi As DataGridView
    Friend WithEvents InJumlah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fumoComboBox As ComboBox
    Friend WithEvents TotalHarga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalHargaTampil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Kembalian As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCetak As Button
    Friend WithEvents BtnBersih As Button
End Class
