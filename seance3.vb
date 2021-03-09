Imports System

class NbrComplexe
    'members
    private reel as decimal
    private imaginary as decimal
    'getters & setters
    public sub setReel(r as decimal)
        reel=r
    end sub
    public function getReel() as decimal
        return reel
    end function
    
    public sub setImaginary(x as decimal)
        imaginary=x
    end sub
    public function getImaginary() as decimal
        return imaginary
    end function
    
    public sub afficher()
        Console.writeLine(reel & " + " & imaginary & " x i")
    end sub
    public sub afficher(delim as char)
        Console.writeLine(reel & " + " & imaginary & " " & delim & " i")
    end sub
    public Function addition(x as decimal) as NbrComplexe
        dim res as NbrComplexe
        res = new NbrComplexe()
        res.setReel(reel+x)
        res.setImaginary(imaginary)
        return res
    end function
    
    public Function addition(x as decimal,y as decimal) as NbrComplexe
        dim res as NbrComplexe
        res = new NbrComplexe()
        res.setReel(reel+x)
        res.setImaginary(imaginary+y)
        return res
    end function
    
    public Function addition(nbr as NbrComplexe) as NbrComplexe
       dim res as NbrComplexe
        res = new NbrComplexe()
        res.setReel(reel+nbr.getReel())
        res.setImaginary(imaginary+nbr.getImaginary())
        return res
    end function
END class
Public Class Test
    Public Shared Sub Main()
        dim nbr1 as NbrComplexe
        dim nbr2 as NbrComplexe
        nbr1= new NbrComplexe()
        nbr1.setReel(10)
        nbr1.setImaginary(5) ' 10 + 5 x i
        
        nbr2= new NbrComplexe()
        nbr2.setReel(4)
        nbr2.setImaginary(3) ' 4 + 3 x i
        'Console.writeLine(nbr1.getReel() & " + " & nbr1.getImaginary() & " x i")
         'Console.writeLine(nbr2.getReel() & " + " & nbr2.getImaginary() & " x i")
         dim somme as NbrComplexe
        somme=nbr2.addition(20,7) ' 15 + 5 * i
        somme.afficher(".")
     
        'nbr1.afficher("x")
    End Sub
End Class