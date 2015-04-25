Imports System
Imports System.Data
Imports System.Linq
Imports System.Xml.Linq
Imports System.Globalization

Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.IO

Imports System.Threading
Imports System.Threading.Tasks

Class MainWindow

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        StartTest1.Visibility = Windows.Visibility.Hidden

        Dim currentDateTime As New Date
        Dim cDT As String
        Dim sp As String
        Dim currentDate As String
        Dim currentTime As String

        Dim newDateTime As New Date
        Dim nDT As String
        Dim newDate As String
        Dim newTime As String

        Dim myUpdate As XDocument
        Dim mySchedule As XDocument

        Dim fileDirectory = "C:\Users\Larry\Documents\GitHub\NewLoserPool\"

        Dim t1 = 3
        Dim t2 = 3
        Dim t3 = 1

        currentDateTime = DateTime.Now

        cDT = currentDateTime.ToString("g")

        sp = cDT.IndexOf(" ")

        currentDate = cDT.Substring(0, sp)
        currentTime = cDT.Substring(sp + 1)

        ' Create Schedule Files for Week1-3 using new times
        newDateTime = currentDateTime.AddMinutes(t1)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        mySchedule = XDocument.Load(fileDirectory + "ScheduleFileWeek1.xml")

        For Each game In mySchedule.Descendants("schedule").Descendants("week").Descendants("game")

            game.Element("startDate").Value = newDate
            game.Element("startTime").Value = newTime

        Next

        mySchedule.Save(fileDirectory + "ScheduleFileWeek1.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        mySchedule = XDocument.Load(fileDirectory + "ScheduleFileWeek2.xml")

        For Each game In mySchedule.Descendants("schedule").Descendants("week").Descendants("game")

            game.Element("startDate").Value = newDate
            game.Element("startTime").Value = newTime

        Next

        mySchedule.Save(fileDirectory + "ScheduleFileWeek2.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        mySchedule = XDocument.Load(fileDirectory + "ScheduleFileWeek3.xml")

        For Each game In mySchedule.Descendants("schedule").Descendants("week").Descendants("game")

            game.Element("startDate").Value = newDate
            game.Element("startTime").Value = newTime

        Next

        mySchedule.Save(fileDirectory + "ScheduleFileWeek3.xml")

        'Create Scoring update files using new times

        newDateTime = currentDateTime.AddMinutes(t1)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update0.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek1Update0.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update1.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek1Update1.xml")


        newDateTime = currentDateTime.AddMinutes(t1 + 2 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update2.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek1Update2.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update3.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek1Update3.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update0.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek2Update0.xml")


        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update1.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek2Update1.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 2 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update2.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek2Update2.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update3.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek2Update3.xml")


        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update0.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek3Update0.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2 + t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update1.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek3Update1.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2 + 2 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update2.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdateWeek3Update2.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2 + 3 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update3.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save(fileDirectory + "scoringUpdate.xml")


        myUpdate = XDocument.Load(fileDirectory + "scoringUpdatePreseason.xml")

        Dim queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                               .homescore = CInt(game.Elements("homescore").Value),
                                               .awayteam = game.Attribute("awayteam").Value,
                                               .awayscore = CInt(game.Elements("awayscore").Value),
                                               .gametime = game.Elements("gametime").Value}).ToList

        Dim allGamesAreFinal As Boolean = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek0.xml")
        End If

        myUpdate.Save(fileDirectory + "scoringUpdate.xml")



        Thread.Sleep(TimeSpan.FromMinutes(t1))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update0.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                               .homescore = CInt(game.Elements("homescore").Value),
                                               .awayteam = game.Attribute("awayteam").Value,
                                               .awayscore = CInt(game.Elements("awayscore").Value),
                                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek1.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))


        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update1.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                               .homescore = CInt(game.Elements("homescore").Value),
                                               .awayteam = game.Attribute("awayteam").Value,
                                               .awayscore = CInt(game.Elements("awayscore").Value),
                                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek1.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update2.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek1.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek1Update3.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek1.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t2))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update0.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek2.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update1.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek2.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update2.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek2.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek2Update3.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek2.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t2))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update0.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek3.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update1.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek3.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update2.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                    Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek3.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        Thread.Sleep(TimeSpan.FromMinutes(t3))

        myUpdate = XDocument.Load(fileDirectory + "scoringUpdateWeek3Update3.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save(fileDirectory + "scoringUpdateFinalWeek3.xml")
        End If


        myUpdate.Save(fileDirectory + "scoringUpdate.xml")

        StartTest1.Visibility = Windows.Visibility.Visible


    End Sub

End Class
