Public Class Form1
    ' Declare a Queue to store task names and priorities
    Private taskQueue As New Queue(Of Tuple(Of String, Integer))()

    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        ' Your existing code for adding a task to the queue goes here

        Dim stTaskName As String
        Dim intPriorityLevel As Integer

        ' Retrieve task information from text boxes
        stTaskName = txtTaskName.Text

        ' Convert text input to Integer for Priority Level
        If Integer.TryParse(txtPriorityLevel.Text, intPriorityLevel) Then
            ' Successfully converted text input to Integer
            ' Add task name and priority to the queue
            taskQueue.Enqueue(New Tuple(Of String, Integer)(stTaskName, intPriorityLevel))

            ' Clear text fields
            txtTaskName.Clear()
            txtPriorityLevel.Clear()

            ' Display a message to indicate successful addition to the queue
            MessageBox.Show($"Task '{stTaskName}' with Priority Level {intPriorityLevel} added to the queue.")
        Else
            ' Conversion failed, handle the error (e.g., display an error message)
            MessageBox.Show("Please enter a valid numeric value for Priority Level.")
        End If

        ' This event handler remains unchanged for adding tasks
    End Sub

    Private Sub btnTaskDelete_Click(sender As Object, e As EventArgs) Handles btnTaskDelete.Click
        ' Retrieve task name to be deleted from text box
        Dim taskToDelete As String = txtDelete.Text

        ' Check if the queue contains any tasks
        If taskQueue.Count > 0 Then
            ' Flag to track if task is found and deleted
            Dim taskFound As Boolean = False

            ' Iterate through the queue to find and remove the task
            Dim queueLength As Integer = taskQueue.Count
            For i As Integer = 0 To queueLength - 1
                Dim task As Tuple(Of String, Integer) = taskQueue.Dequeue()
                If task.Item1 = taskToDelete Then
                    ' Task found and removed
                    taskFound = True
                    MessageBox.Show($"Task '{taskToDelete}' removed from the queue.")
                Else
                    ' Task not found, add it back to the queue
                    taskQueue.Enqueue(task)
                End If
            Next

            ' If task was not found, display message
            If Not taskFound Then
                MessageBox.Show($"Task '{taskToDelete}' not found in the queue.")
            End If
        Else
            ' Queue is empty, display message
            MessageBox.Show("No tasks in the queue to delete.")
        End If

        ' Clear the text box for next input
        txtDelete.Clear()
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ' Your existing code for executing tasks based on priority goes here
        If taskQueue.Count > 0 Then
            ' Sort tasks based on priority level before displaying them
            Dim sortedTasks = taskQueue.OrderBy(Function(task) task.Item2)

            ' Display sorted tasks in the order of priority
            Dim taskInfo As String = "Tasks to be executed based on priority:" & vbCrLf
            For Each task In sortedTasks
                taskInfo &= $"Task Name: {task.Item1}, Priority Level: {task.Item2}" & vbCrLf
            Next

            MessageBox.Show(taskInfo, "Execution Order")
        Else
            MessageBox.Show("No tasks in the queue.", "Queue Empty")
        End If
        ' This event handler remains unchanged for executing tasks
    End Sub
End Class
