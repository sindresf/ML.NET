﻿open System.Drawing
open System.Windows.Forms

type HelloWindow() =
    let frm = new Form(Width = 400, Height = 140)
    let fnt = new Font("Times New Roman", 28.0f)
    let lbl = new Label(Dock = DockStyle.Fill, Font = fnt,
                        TextAlign = ContentAlignment.MiddleCenter)
    do frm.Controls.Add(lbl)

    member x.SayHello(name) = 
        let msg = "hello " + name + "!"
        lbl.Text <- msg

    member r.Run() =
        frm.ShowDialog()

let hello = new HelloWindow()
hello.SayHello("Sindre")
hello.Run()