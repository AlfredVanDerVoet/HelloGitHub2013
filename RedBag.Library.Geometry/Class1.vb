Public MustInherit Class Geometry3D

    Public MustOverride Function OuterSurfaceArea() As Double
    Public MustOverride Function InnterSurfaceArea() As Double
    Public MustOverride Function IsSolid() As Double
    Public MustOverride Function InnerVolumn() As Double
    Public MustOverride Function OuterVolumn() As Double
    Public MustOverride Function WeightUnitMaterial() As Double
    Public MustOverride Function NormalVector() As Double()

    Public MustOverride Function ContentVolumn(Percentage As Double) As Double

End Class
