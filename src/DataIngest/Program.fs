open FSharp.Data.LiteralProviders
open FSharpx.Text.Regex.Compiled

let splitLines (s:string) = 
    List.ofSeq(s.Split([|'\n'|]))
    
let churnLines input f =
    splitLines
    >> List.filter
           (not << System.String.IsNullOrWhiteSpace)
    >> List.map f
    <| input
    
let churnLinesNoHeader input f =
    splitLines
    >> List.skip 1
    >> List.filter
           (not << System.String.IsNullOrWhiteSpace)
    >> List.map f
    <| input

let join input = seq { yield! input; "\n" } |> String.concat "\n"

let clean (name: string) =
    let replace (input: string) (char: string) = input.Replace(char, "_")
    let mutable result = name
    seq {"\""; "`"; "."; "/"; "["; "]"; "+"; "("; ")"}
    |> Seq.iter(fun char -> result <- replace result char)
    result

let [<Literal>] cellText = TextFile<"cellID.txt", EnsureExists=true>.Text

type cellInfo = { cellId: int; cellString: string }

let parseCell input =
    match input with
    | Match " +(\d+) +(.+)\r?" matches ->
        { cellId = matches.GroupValues.[0] |> int
          cellString = matches.GroupValues.[1] }
    | _ -> failwith $"Parsing fail in cell data: {input}"
let cellEnumType =
    let header = "type cell ="
    let line info = $"    | ``{info.cellString.Trim()}`` = {info.cellId}"
    let cellInfos = churnLines cellText parseCell
    let lines = List.map line cellInfos
    seq { header; yield! lines } |> join
    
let [<Literal>] itemText = TextFile<"itemID.txt", EnsureExists=true>.Text

type itemInfo = { itemId: int; itemString: string }
let parseItem input =
    match input with
    | Match " *(\d+) (.+)$" matches ->
        { itemId = matches.GroupValues.[0] |> int
          itemString = clean <| matches.GroupValues.[1].Trim() }
    | _ -> failwith "Parsing fail in item data"
    
let itemInfos = churnLines itemText parseItem

let itemDuType =
    let header = "[<RequireQualifiedAccess>]\ntype Item ="
    let line info = $"    | ``{clean info.itemString}``"
    let lines = List.map line itemInfos
    seq { header; yield! lines } |> join
    
let itemIdMap =
    let header = "let itemId ="
    let functionStatement = "    function"
    let line info = $"    | {info.itemId} -> Item.``{clean info.itemString}``"
    let lines = List.map line itemInfos
    let catch = "    | x -> raise (System.ArgumentException(sprintf \"Invalid item id! %A\" x))"
    seq { header; functionStatement; yield! lines ; catch } |> join
    
let itemStringMap =
    let header = "let itemString ="
    let functionStatement = "    function"
    let line info = $"    | Item.``{clean info.itemString}`` -> \"{info.itemString}\""
    let lines = List.map line itemInfos
    let catch = "    | x -> raise (System.ArgumentException(sprintf \"Invalid item id! %A\" x))"
    seq { header; functionStatement; yield! lines ; catch } |> join

let [<Literal>] propText = TextFile<"propID.txt", EnsureExists=true>.Text

type propInfo = { propTag: string; propKind: string; propId: int }

let parseProp input =
    match input with
    | Match " *(\d+) +(.+)  (.+)\r?" matches ->
        { propId = matches.GroupValues.[0] |> int
          propTag = matches.GroupValues.[1].Trim()
          propKind = matches.GroupValues.[2].Trim() }
    | _ -> failwith "Parsing fail in prop data"

let propInfos = churnLinesNoHeader propText parseProp

let propDuType =
    let header = "[<RequireQualifiedAccess>]\ntype Prop ="
    let line info = $"    | ``{clean info.propTag}``"
    let lines = List.map line propInfos
    seq { header; yield! lines } |> join
    
let propIdMap =
    let header = "let getProp ="
    let functionStatement = "    function"
    let line info = $"    | {info.propId} -> Prop.``{clean info.propTag}``"
    let lines = List.map line propInfos
    let catch = "    | x -> raise (System.ArgumentException(sprintf \"Invalid value for prop type: %A\" x))"
    seq { header; functionStatement; yield! lines; catch } |> join

let [<Literal>] entityText = TextFile<"entityID.txt", EnsureExists=true>.Text

type entityInfo = { entityTag: string; entityName: string; entityId: int }

let parseEntity =
    function
    | Match " *(\d+) +(.+)  (.+)\r?" matches ->
        { entityId = matches.GroupValues.[0] |> int 
          entityTag = matches.GroupValues.[1].Trim()
          entityName = matches.GroupValues.[2].Trim() }
    | _ -> failwith "Parsing fail in entity data"

let entityInfos = churnLinesNoHeader entityText parseEntity

let entityEnumType =
    let header = "[<RequireQualifiedAccess>]\ntype Entity ="
    let line info = $"    | ``{clean info.entityTag}`` = {info.entityId}"
    let lines = List.map line entityInfos
    seq { header; yield! lines } |> join
    
let entityIdMap =
    let header = "let getEntity ="
    let functionStatement = "    function"
    let line info = $"    | {info.entityId} -> Entity.``{clean info.entityTag}``"
    let lines = List.map line entityInfos
    let catch = "    | x -> raise (System.ArgumentException(sprintf \"Invalid value for entity type: %A\" x))"
    seq { header; functionStatement; yield! lines; catch } |> join

//printfn $"{cellEnumType}"
//printfn $"{itemDuType}"
//printfn $"{itemIdMap}"
//printfn $"{itemStringMap}"
//printfn $"{propDuType}"
//printfn $"{propIdMap}"
//printfn $"{entityEnumType}"
printfn $"{entityIdMap}"
 