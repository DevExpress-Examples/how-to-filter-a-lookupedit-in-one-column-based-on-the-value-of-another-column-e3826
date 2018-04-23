﻿' Developer Express Code Central Example:
' How to filter a LookUpEdit in one column based on the value of another column
' 
' This example illustrates how to filter LookUpEdit item source values in one
' column based on the value of another column. This functionality can be
' implemented only when a filtered LookUpEdit is introduced using a cell template.
' In this case, every cell has an independent LookUpEdit editor, and we can
' manipulate its item source. The item source is filtered in the
' TableView.ShownEditor event handler. This event is raised when a cell gets
' focus, and its editor becomes active, so it is the best place to filter the item
' source.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3826

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.239
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
