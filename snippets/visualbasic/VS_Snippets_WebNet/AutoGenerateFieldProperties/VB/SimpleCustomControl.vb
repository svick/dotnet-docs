﻿' <Snippet1>

Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Security.Permissions
Imports System.Web

Namespace Samples.AspNet.VB.Controls

    <AspNetHostingPermission(SecurityAction.Demand, Level:=AspNetHostingPermissionLevel.Minimal), AspNetHostingPermission(SecurityAction.InheritanceDemand, Level:=AspNetHostingPermissionLevel.Minimal)> Public Class SimpleCustomControl
        Inherits System.Web.UI.WebControls.DetailsView

        Protected Overrides Function CreateAutoGeneratedRow(ByVal fieldProperties As AutoGeneratedFieldProperties) As AutoGeneratedField

            ' Create an AutoGeneratedField object.
            Dim field As New AutoGeneratedField(fieldProperties.DataField)

            ' Set the properties of the AutoGeneratedField using
            ' the values from the AutoGeneratedFieldProperties 
            ' object contained in the fieldProperties parameter.
            CType(field, IStateManager).TrackViewState()
            field.HeaderText = fieldProperties.Name
            field.SortExpression = fieldProperties.Name
            field.ReadOnly = fieldProperties.IsReadOnly
            field.DataType = fieldProperties.Type

            Return field

        End Function

    End Class

End Namespace

' </Snippet1>