module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int

let rec prod (t:Tree) :int =
 
 match t with 
  | Node(t1, t2) -> prod(t1)*prod(t2)
  | Node(Leaf a, Leaf b) -> a * b
  | Leaf a -> a
  | _ -> 0
let rec map (f:int->int) (t:Tree) :Tree =
  match t with 


let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
