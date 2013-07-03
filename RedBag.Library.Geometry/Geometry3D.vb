Public MustInherit Class Geometry3D

    Public MustOverride Function OuterSurfaceArea() As Double
    Public MustOverride Function InternalSurfaceArea() As Double
    Public MustOverride Function IsSolid() As Double
    Public MustOverride Function InnerVolumn() As Double
    Public MustOverride Function OuterVolumn() As Double
    Public MustOverride Function WeightForUnitMaterial() As Double

    Public MustOverride Function Internals() As Geometry3D()

End Class
