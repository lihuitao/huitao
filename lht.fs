[<AbstractClass>]
type Animal() = 
    abstract Work : unit -> unit
    member x.Fight() = 
        printfn "for Alias!"
type Sheep() = 
    inherit Animal() with
        member x.Work() = 
            printfn "I'm work!"

type ILifeForm =
    abstract Speak : unit -> unit
    abstract Eat : unit -> unit 

type Dog() = 
    interface ILifeForm with
        member x.Speak() = 
            printfn "汪汪!"
        member x.Eat() = 
            printfn "狗吃点肉"
type Cat() = 
    interface ILifeForm with
        member x.Speak() =
            printfn "喵喵!"
        member x.Eat() = 
            printfn "猫吃点鱼"
type Student = 
    { Name : string
      Age : int
    }

[<EntryPoint>]
let main argv = 
    let aStudent = { Name = "lihuitao"; Age = 42 }
    let bStudent = { Name = "liyan"; Age = 37 }
    printfn "%s" aStudent.Name
    let aDog = new Dog()
    (aDog :> ILifeForm).Speak()
    0

