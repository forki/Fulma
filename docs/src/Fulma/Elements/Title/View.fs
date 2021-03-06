module Elements.Title.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types
open Fulma.Elements

let simpleInteractive =
    div [ ]
        [ Heading.h1 [ ]
            [ str "Title" ]
          Heading.h2 [ Heading.isSubtitle ]
            [ str "Subtitle" ] ]


let sizeInteractive =
    div [ ]
        [ Heading.h1 [ ]
            [ str "Title 1" ]
          Heading.h2 [ ]
            [ str "Title 2" ]
          Heading.h3 [ ]
            [ str "Title 3" ]
          Heading.h4 [ ]
            [ str "Title 3" ]
          Heading.h5 [ ]
            [ str "Title 5" ]
          Heading.h6 [ ]
            [ str "Title 6" ]
          Heading.h1 [ Heading.isSubtitle ]
            [ str "Subtitle 1" ]
          Heading.h2 [ Heading.isSubtitle ]
            [ str "Subtitle 2" ]
          Heading.h3 [ Heading.isSubtitle ]
            [ str "Subtitle 3" ]
          Heading.h4 [ Heading.isSubtitle ]
            [ str "Subtitle 4" ]
          Heading.h5 [ Heading.isSubtitle ]
            [ str "Subtitle 5" ]
          Heading.h6 [ Heading.isSubtitle ]
            [ str "Subtitle 6" ] ]

let root model dispatch =
    Render.docPage [ Render.contentFromMarkdown model.Intro
                     Render.docSection
                        """
### Types

**Title** can be of two types *Title* and *Subtitle*.

By default, `Header.h1 [ ] [ ]` generate a title. You can specify `Heading.isSubtitle` if needed.
                        """
                        (Viewer.View.root simpleInteractive model.TypeViewer (TypeViewerMsg >> dispatch))
                     Render.docSection
                        """
### Sizes

Elmish.Bulma already associate each header size with the equivalent class.

For example, `Heading.h1 [ Heading.isTitle ] [ str "Title 1" ]` will output `<h1 class="title is-1">Title 1</h1>`
                        """
                        (Viewer.View.root sizeInteractive model.SizeViewer (SizeViewerMsg >> dispatch))
                     Render.contentFromMarkdown
                        """We also provide `Heading.isSpaced` helper. See the *[bulma documentation](http://bulma.io/documentation/elements/title/)* to learn more about it.""" ]
