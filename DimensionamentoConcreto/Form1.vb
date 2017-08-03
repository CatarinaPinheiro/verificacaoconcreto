
'---------------------------------Dimensionamento a Flexão Normal Composta ---------------------------------------------'
'-------------------------------Autora: Catarina de Nazaré Pereira Pinheiro---------------------------------------------'


Public Class Calc
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---Entrada de Dados----'
        Dim base As Double = Convert.ToDouble(txtbase)
        Dim Altura As Double = Convert.ToDouble(txtaltura)
        Dim Fck As Integer = Convert.ToInt32(txtfck) / 1.4
        Dim Fyk As Integer = Convert.ToInt32(txtfyk) / 1.15
        Dim γsp As Double = Convert.ToDouble(txtprotensao)
        Dim Momento As Double = Convert.ToDouble(txtmomento)
        Dim EsfNormal As Double = Convert.ToDouble(txtforca)
        Dim Esc As Integer = 210000
        Dim nc As Integer = 100

        Dim yc(nc) As Double 'Distância da camada de concreto selecionada até o centroide da seção'
        Dim Armadura(nc) As Double
        Dim Ds(nc) As Double

        For i = 1 To nc
            yc(i) = Altura / 2 - (Altura / (2 * nc)) - (Altura * (i - 1) / nc)

        Next

        '---Cálculo Deformação---'
        Dim x As Double
        x = (Altura + 0) / 2

        Dim phi As Double
        phi = (-0.0035 / (Altura / 2)) 'Negativo - Convenções de Sinais'

        Dim epsiloncg As Double
        epsiloncg = phi * (Altura / 2) + 0.0035



    End Sub

End Class
