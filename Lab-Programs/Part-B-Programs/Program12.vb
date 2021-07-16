Imports System

Public Class student_grading
    Dim no_of_subs As Integer
    Dim marks(no_of_subs) As Integer
    Dim name_of_student As String
    Dim grade As Char
    Dim avg As Double = 0

    Sub get_data(number_of_subjects As Integer)
        no_of_subs = number_of_subjects
        ReDim marks(no_of_subs)
        Console.WriteLine("Enter your name")
        name_of_student = Console.ReadLine()
        Console.WriteLine("Enter your marks in:")

        For i As Integer = 0 To (no_of_subs - 1)
            Console.Write("Subject {0}: ", i + 1)
            marks(i) = Console.ReadLine()
            avg = avg + (marks(i) / no_of_subs)
        Next
    End Sub

    Sub grade_student()
        If (avg >= 85) Then
            grade = "A"
        ElseIf (avg >= 75 And avg < 85) Then
            grade = "B"
        ElseIf (avg >= 65 And avg < 75) Then
            grade = "C"
        Else
            grade = "D"
        End If
    End Sub

    Sub display()
        Console.WriteLine("Name: {0}", name_of_student)
        For i As Integer = 0 To (no_of_subs - 1)
            Console.WriteLine("Marks in Subject {0}: {1}", i + 1, marks(i))
        Next

        Console.WriteLine("Average of all subjects is: {0} ", avg)
        Console.WriteLine("Hence the grade given to {0} is: {1}", name_of_student, grade)
    End Sub
End Class


Module Program12
    Sub Main()
        Dim student1 As New student_grading

        student1.get_data(5)
        student1.grade_student()
        student1.display()

        Console.ReadKey()
    End Sub
End Module
