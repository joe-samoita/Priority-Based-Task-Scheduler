<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtTaskName = New TextBox()
        txtPriorityLevel = New TextBox()
        lblTaskName = New Label()
        LblPriorityLevel = New Label()
        btnExecute = New Button()
        Label1 = New Label()
        btnAddTask = New Button()
        btnTaskDelete = New Button()
        txtDelete = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtTaskName
        ' 
        txtTaskName.Location = New Point(297, 89)
        txtTaskName.Name = "txtTaskName"
        txtTaskName.Size = New Size(120, 23)
        txtTaskName.TabIndex = 0
        ' 
        ' txtPriorityLevel
        ' 
        txtPriorityLevel.Location = New Point(297, 129)
        txtPriorityLevel.Name = "txtPriorityLevel"
        txtPriorityLevel.Size = New Size(120, 23)
        txtPriorityLevel.TabIndex = 1
        ' 
        ' lblTaskName
        ' 
        lblTaskName.AutoSize = True
        lblTaskName.Location = New Point(198, 92)
        lblTaskName.Name = "lblTaskName"
        lblTaskName.Size = New Size(67, 15)
        lblTaskName.TabIndex = 3
        lblTaskName.Text = "Task Name:"
        ' 
        ' LblPriorityLevel
        ' 
        LblPriorityLevel.AutoSize = True
        LblPriorityLevel.Location = New Point(198, 132)
        LblPriorityLevel.Name = "LblPriorityLevel"
        LblPriorityLevel.Size = New Size(78, 15)
        LblPriorityLevel.TabIndex = 4
        LblPriorityLevel.Text = "Priority Level:"
        ' 
        ' btnExecute
        ' 
        btnExecute.Location = New Point(270, 295)
        btnExecute.Name = "btnExecute"
        btnExecute.Size = New Size(105, 33)
        btnExecute.TabIndex = 6
        btnExecute.Text = "Execute"
        btnExecute.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(226, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 29)
        Label1.TabIndex = 7
        Label1.Text = "Task Scheduler"
        ' 
        ' btnAddTask
        ' 
        btnAddTask.Location = New Point(270, 172)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(104, 30)
        btnAddTask.TabIndex = 8
        btnAddTask.Text = "Add Tasks"
        btnAddTask.UseVisualStyleBackColor = True
        ' 
        ' btnTaskDelete
        ' 
        btnTaskDelete.BackColor = SystemColors.Control
        btnTaskDelete.Location = New Point(274, 266)
        btnTaskDelete.Name = "btnTaskDelete"
        btnTaskDelete.Size = New Size(100, 23)
        btnTaskDelete.TabIndex = 9
        btnTaskDelete.Text = "Delete Task"
        btnTaskDelete.UseVisualStyleBackColor = False
        ' 
        ' txtDelete
        ' 
        txtDelete.Location = New Point(296, 219)
        txtDelete.Name = "txtDelete"
        txtDelete.Size = New Size(121, 23)
        txtDelete.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 11
        Label2.Text = "Enter Task Name :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(652, 356)
        Controls.Add(Label2)
        Controls.Add(txtDelete)
        Controls.Add(btnTaskDelete)
        Controls.Add(btnAddTask)
        Controls.Add(Label1)
        Controls.Add(btnExecute)
        Controls.Add(LblPriorityLevel)
        Controls.Add(lblTaskName)
        Controls.Add(txtPriorityLevel)
        Controls.Add(txtTaskName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents txtPriorityLevel As TextBox
    Friend WithEvents lblTaskName As Label
    Friend WithEvents LblPriorityLevel As Label
    Friend WithEvents btnExecute As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnTaskDelete As Button
    Friend WithEvents txtDelete As TextBox
    Friend WithEvents Label2 As Label

End Class
