Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common


Module Module1
    Public LastVersion As Integer = 66
    Public MyProjectType As ProjectType = ProjectType.Full
    Public MyProject As Project = Project.Pyramakerz
    Public StopProfiler As Boolean = False


    Dim RemotePass As String = "P123456789!@#$%^&*("



    'Color.SkyBlue
    'Color.Olive
    'Color.LightSkyBlue
    'Color.DarkBlue   'Black
    Public MyBackColor As Color = Color.Navy
    Public MyLblBackColor As Color = Color.Orange

    Public Key As Integer = 8
    Public cmd As New SqlCommand
    Public con As New SqlConnection
    Public s As New SqlClient.SqlConnectionStringBuilder
    Public FourceExit As Boolean = False
    Public HasLeft As Boolean = False

    Public SystemAdmin, UserName, ArName, EnName, JobId, Manager, LevelId, Password, Branch, CountryId, CityId As String
    Public GeneralManager, Board, Accountant, CountryManager, CityManager, HeadOfDepartment, Supervisor As String
    Public ThisCountryManager, ThisCityManager, ThisBranchManager As String
    Public MyChildCountry, MyChildCityCountry, MyChildCity, MyChildBranch As String

    Enum Project
        Pyramakerz
        EFG
    End Enum

    Enum ProjectType
        Full
        PlacemeteTest
        PCs
        Table
    End Enum


End Module
