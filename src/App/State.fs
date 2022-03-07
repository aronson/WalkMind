module State

type Stateful<'state, 'result> = Stateful of ('state -> 'result * 'state)

let inline run state x = let (Stateful (f)) = x in f state
let get = Stateful(fun s -> s, s)
let put newState = Stateful(fun _ -> (), newState)
let ret result = Stateful(fun state -> (result, state))

let bind f s =
    Stateful (fun (state: 'state) ->
        let x, state = run state s
        f x, state)

/// The state monad passes around an explicit internal state that can be
/// updated along the way. It enables the appearance of mutability in a purely
/// functional context by hiding away the state when used with its proper operators
/// (in StateBuilder()). In other words, you implicitly pass around an implicit
/// state that gets transformed along its journey through pipelined code.
type StateBuilder() =
    let (>>=) stateful binder = bind binder stateful
    member __.Return(result) = ret result
    member __.ReturnFrom(stateful) = stateful
    member __.Bind(stateful, binder) = stateful >>= binder
    member __.Zero() = ret ()
    member __.Combine(statefulA, statefulB) = statefulA >>= (fun _ -> statefulB)
    member __.Delay(f) = f ()

let stateful = new StateBuilder()

/// Cons the input to the state
let push x =
    Stateful(fun (s: 's seq) -> (), Seq.append [ x ] s)
/// Update and remove the return value from the top of the stack
let pop =
    Stateful(fun (s: 's seq) -> Seq.head s, Seq.tail s)
/// Update the return value to the top of the stack
let peek =
    Stateful(fun (s: 's seq) -> Seq.head s, s)
