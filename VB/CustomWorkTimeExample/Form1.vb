Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace CustomWorkTimeExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Me.Text = Application.ProductName

            AddHandler schedulerControl1.QueryWorkTime, AddressOf SchedulerControl1_QueryWorkTime

            InitializeScheduler()

        End Sub

        Private Sub InitializeScheduler()
            For i As Integer = 1 To 4
                Dim res As Resource = schedulerControl1.DataStorage.Resources.CreateResource(i, i.ToString())
                schedulerControl1.DataStorage.Resources.Add(res)
            Next i
            schedulerControl1.ActiveViewType = SchedulerViewType.FullWeek
            schedulerControl1.GroupType = SchedulerGroupType.Resource
            schedulerControl1.DateNavigationBar.Visible = False
            schedulerControl1.OptionsView.NavigationButtons.Visibility = NavigationButtonVisibility.Never
        End Sub
        #Region "#QueryWorkTime"
        Private Sub SchedulerControl1_QueryWorkTime(ByVal sender As Object, ByVal e As QueryWorkTimeEventArgs)
            If e.Resource.Id.Equals(1) Then
                If e.Interval.Start.Day Mod 2 = 0 Then
                    Dim workTimes As New List(Of TimeOfDayInterval)()
                    workTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(0), TimeSpan.FromHours(3)))
                    workTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(5), TimeSpan.FromHours(8)))
                    workTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(10), TimeSpan.FromHours(11)))
                    e.WorkTimes.AddRange(workTimes)
                Else
                    e.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(20))
                End If
            End If
            If e.Resource.Id.Equals(2) Then
                If e.Interval.Start.Day Mod 2 = 0 Then
                    e.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(14), TimeSpan.FromHours(18))
                Else
                    e.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(12))
                End If
            End If
            If e.Resource.Id.Equals(3) Then
                e.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(14), TimeSpan.FromHours(21))
            End If
            If e.Resource.Id.Equals(4) Then
                Dim workTimes As New List(Of TimeOfDayInterval)()
                workTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(11)))
                workTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(13), TimeSpan.FromHours(17)))
                e.WorkTimes.AddRange(workTimes)
            End If
        End Sub
        #End Region ' #QueryWorkTime
    End Class

End Namespace
