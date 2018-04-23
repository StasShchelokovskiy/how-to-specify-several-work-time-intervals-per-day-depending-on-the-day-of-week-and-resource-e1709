Namespace CustomWorkTimeExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim schedulerColorSchema1 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema2 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema3 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema4 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema5 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema6 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema7 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema8 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema9 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema10 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema11 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim schedulerColorSchema12 As New DevExpress.XtraScheduler.SchedulerColorSchema()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.DataStorage = Me.schedulerStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            schedulerColorSchema1.Cell = System.Drawing.Color.FromArgb((CInt((CByte(229)))), (CInt((CByte(229)))), (CInt((CByte(229)))))
            schedulerColorSchema1.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
            schedulerColorSchema1.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(165)))), (CInt((CByte(165)))), (CInt((CByte(165)))))
            schedulerColorSchema1.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            schedulerColorSchema1.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(216)))), (CInt((CByte(216)))), (CInt((CByte(216)))))
            schedulerColorSchema1.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(178)))), (CInt((CByte(178)))), (CInt((CByte(178)))))
            schedulerColorSchema2.Cell = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(240)))), (CInt((CByte(240)))))
            schedulerColorSchema2.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
            schedulerColorSchema2.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
            schedulerColorSchema2.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            schedulerColorSchema2.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
            schedulerColorSchema2.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
            schedulerColorSchema3.Cell = System.Drawing.Color.FromArgb((CInt((CByte(179)))), (CInt((CByte(212)))), (CInt((CByte(151)))))
            schedulerColorSchema3.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(168)))), (CInt((CByte(203)))), (CInt((CByte(138)))))
            schedulerColorSchema3.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(140)))), (CInt((CByte(180)))), (CInt((CByte(104)))))
            schedulerColorSchema3.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(236)))), (CInt((CByte(188)))))
            schedulerColorSchema3.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(205)))), (CInt((CByte(228)))), (CInt((CByte(180)))))
            schedulerColorSchema3.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(186)))), (CInt((CByte(209)))), (CInt((CByte(162)))))
            schedulerColorSchema4.Cell = System.Drawing.Color.FromArgb((CInt((CByte(139)))), (CInt((CByte(158)))), (CInt((CByte(191)))))
            schedulerColorSchema4.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(147)))), (CInt((CByte(181)))))
            schedulerColorSchema4.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(97)))), (CInt((CByte(116)))), (CInt((CByte(152)))))
            schedulerColorSchema4.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(207)))), (CInt((CByte(216)))), (CInt((CByte(230)))))
            schedulerColorSchema4.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(193)))), (CInt((CByte(201)))), (CInt((CByte(219)))))
            schedulerColorSchema4.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(161)))), (CInt((CByte(175)))), (CInt((CByte(204)))))
            schedulerColorSchema5.Cell = System.Drawing.Color.FromArgb((CInt((CByte(190)))), (CInt((CByte(134)))), (CInt((CByte(161)))))
            schedulerColorSchema5.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(180)))), (CInt((CByte(124)))), (CInt((CByte(149)))))
            schedulerColorSchema5.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(156)))), (CInt((CByte(101)))), (CInt((CByte(122)))))
            schedulerColorSchema5.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(203)))), (CInt((CByte(214)))))
            schedulerColorSchema5.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(218)))), (CInt((CByte(189)))), (CInt((CByte(199)))))
            schedulerColorSchema5.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(197)))), (CInt((CByte(163)))), (CInt((CByte(171)))))
            schedulerColorSchema6.Cell = System.Drawing.Color.FromArgb((CInt((CByte(137)))), (CInt((CByte(177)))), (CInt((CByte(167)))))
            schedulerColorSchema6.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(123)))), (CInt((CByte(168)))), (CInt((CByte(156)))))
            schedulerColorSchema6.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(142)))), (CInt((CByte(128)))))
            schedulerColorSchema6.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(193)))), (CInt((CByte(214)))), (CInt((CByte(209)))))
            schedulerColorSchema6.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(174)))), (CInt((CByte(202)))), (CInt((CByte(195)))))
            schedulerColorSchema6.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(145)))), (CInt((CByte(182)))), (CInt((CByte(173)))))
            schedulerColorSchema7.Cell = System.Drawing.Color.FromArgb((CInt((CByte(247)))), (CInt((CByte(180)))), (CInt((CByte(127)))))
            schedulerColorSchema7.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(167)))), (CInt((CByte(113)))))
            schedulerColorSchema7.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(202)))), (CInt((CByte(131)))), (CInt((CByte(71)))))
            schedulerColorSchema7.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(250)))), (CInt((CByte(208)))), (CInt((CByte(174)))))
            schedulerColorSchema7.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(196)))), (CInt((CByte(163)))))
            schedulerColorSchema7.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(225)))), (CInt((CByte(166)))), (CInt((CByte(118)))))
            schedulerColorSchema8.Cell = System.Drawing.Color.FromArgb((CInt((CByte(221)))), (CInt((CByte(140)))), (CInt((CByte(142)))))
            schedulerColorSchema8.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(210)))), (CInt((CByte(129)))), (CInt((CByte(131)))))
            schedulerColorSchema8.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(179)))), (CInt((CByte(100)))), (CInt((CByte(101)))))
            schedulerColorSchema8.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(239)))), (CInt((CByte(200)))), (CInt((CByte(201)))))
            schedulerColorSchema8.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(233)))), (CInt((CByte(187)))), (CInt((CByte(189)))))
            schedulerColorSchema8.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(222)))), (CInt((CByte(164)))), (CInt((CByte(166)))))
            schedulerColorSchema9.Cell = System.Drawing.Color.FromArgb((CInt((CByte(137)))), (CInt((CByte(150)))), (CInt((CByte(132)))))
            schedulerColorSchema9.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(129)))), (CInt((CByte(138)))), (CInt((CByte(122)))))
            schedulerColorSchema9.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(102)))), (CInt((CByte(100)))), (CInt((CByte(89)))))
            schedulerColorSchema9.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(216)))), (CInt((CByte(203)))))
            schedulerColorSchema9.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(196)))), (CInt((CByte(207)))), (CInt((CByte(191)))))
            schedulerColorSchema9.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(172)))), (CInt((CByte(181)))), (CInt((CByte(169)))))
            schedulerColorSchema10.Cell = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(199)))), (CInt((CByte(200)))))
            schedulerColorSchema10.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(186)))), (CInt((CByte(187)))))
            schedulerColorSchema10.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(151)))), (CInt((CByte(153)))))
            schedulerColorSchema10.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(168)))), (CInt((CByte(236)))), (CInt((CByte(236)))))
            schedulerColorSchema10.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(144)))), (CInt((CByte(226)))), (CInt((CByte(227)))))
            schedulerColorSchema10.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(203)))), (CInt((CByte(204)))))
            schedulerColorSchema11.Cell = System.Drawing.Color.FromArgb((CInt((CByte(168)))), (CInt((CByte(148)))), (CInt((CByte(207)))))
            schedulerColorSchema11.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(155)))), (CInt((CByte(136)))), (CInt((CByte(194)))))
            schedulerColorSchema11.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(118)))), (CInt((CByte(99)))), (CInt((CByte(155)))))
            schedulerColorSchema11.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(221)))), (CInt((CByte(213)))), (CInt((CByte(236)))))
            schedulerColorSchema11.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(210)))), (CInt((CByte(199)))), (CInt((CByte(230)))))
            schedulerColorSchema11.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(185)))), (CInt((CByte(169)))), (CInt((CByte(216)))))
            schedulerColorSchema12.Cell = System.Drawing.Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
            schedulerColorSchema12.CellBorder = System.Drawing.Color.FromArgb((CInt((CByte(189)))), (CInt((CByte(189)))), (CInt((CByte(189)))))
            schedulerColorSchema12.CellBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(121)))), (CInt((CByte(121)))), (CInt((CByte(121)))))
            schedulerColorSchema12.CellLight = System.Drawing.Color.FromArgb((CInt((CByte(230)))), (CInt((CByte(230)))), (CInt((CByte(230)))))
            schedulerColorSchema12.CellLightBorder = System.Drawing.Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(204)))), (CInt((CByte(204)))))
            schedulerColorSchema12.CellLightBorderDark = System.Drawing.Color.FromArgb((CInt((CByte(177)))), (CInt((CByte(177)))), (CInt((CByte(177)))))
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema1)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema2)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema3)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema4)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema5)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema6)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema7)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema8)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema9)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema10)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema11)
            Me.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema12)
            Me.schedulerControl1.Size = New System.Drawing.Size(784, 561)
            Me.schedulerControl1.Start = New Date(2017, 12, 21, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    End Class
End Namespace

