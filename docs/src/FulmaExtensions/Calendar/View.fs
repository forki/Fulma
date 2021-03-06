module FulmaExtensions.Calendar.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types
open Fulma.Extensions
open Fulma.Elements
open Fulma.Extra.FontAwesome

let basic =
    Calendar.calendar [ ]
        [ Calendar.Nav.nav [ ]
            [ Calendar.Nav.left [ ]
                [ Button.button_a [ Button.isLink ]
                    [ Icon.faIcon [ ] [ Fa.icon Fa.I.ChevronLeft ] ] ]
              span [ ] [ str "August 2017" ]
              Calendar.Nav.right [ ]
                [ Button.button_a [ Button.isLink ]
                    [ Icon.faIcon [ ] [ Fa.icon Fa.I.ChevronRight ] ] ] ]
          div [ ]
            [ Calendar.header [ ]
                [ Calendar.Date.date [ ] [ str "Sun" ]
                  Calendar.Date.date [ ] [ str "Mon" ]
                  Calendar.Date.date [ ] [ str "Tue" ]
                  Calendar.Date.date [ ] [ str "Wed" ]
                  Calendar.Date.date [ ] [ str "Thu" ]
                  Calendar.Date.date [ ] [ str "Fri" ]
                  Calendar.Date.date [ ] [ str "Sat" ] ]
              Calendar.body [ ]
                [ Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "31" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "1" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "2" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "3" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "4" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "5" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "6" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ Calendar.Date.Item.isToday ]
                          [ str "7" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "8" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "9" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "10" ] ]
                  Calendar.Date.date [ Calendar.Date.isRangeStart ]
                      [ Calendar.Date.item [ Calendar.Date.Item.isActive ]
                          [ str "11" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "12" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "13" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "14" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "15" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "16" ] ]
                  Calendar.Date.date [ Calendar.Date.isRangeEnd ]
                      [ Calendar.Date.item [ Calendar.Date.Item.isActive ]
                          [ str "17" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "18" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "19" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "20" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "21" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "22" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "23" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "24" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "25" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "26" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "27" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "28" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "29" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "30" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "31" ] ]
                  Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "1" ] ]
                  Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "2" ] ]
                  Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "3" ] ] ] ] ]

let root model dispatch =
    Render.docPage [ Render.contentFromMarkdown model.Intro
                     Render.docSection
                        ""
                        (Viewer.View.root basic model.BasicViewer (BasicViewerMsg >> dispatch)) ]
