Public Class PenerimaanDExtended
  Inherits PenerimaanD

  Private xSisaBarang As Decimal
  Public Property SisaBarang() As Decimal
    Get
      Return xSisaBarang
    End Get
    Set(ByVal value As Decimal)
      xSisaBarang = value
    End Set
  End Property


End Class
