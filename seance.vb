Imports System

Public Class Test
    class Chien
        private nom as String
        private poids as decimal
        public sub sePresenter()
         System.Console.WriteLine("salut je suis " & nom & " et j'ai le poids = " & poids)
        end sub
        public function getPoids() as decimal
            return poids
        end function
        public sub setPoids(val as decimal)
            if val>0 then
            poids=val
            end if
        end sub
        'acceseeur ou getter
        public function getNom() as String
            return nom
        end function
        'modificateur ou setter
        public sub setNom(val as String)
            nom=val
        end sub
    END class
    
    Public Shared Sub Main()
        dim chien as Chien
        chien = new Chien()
        chien.setNom("alex")
        chien.setPoids(-100)
    
         dim chien2 as Chien
        chien2 = new Chien()
        chien2.setNom("REX")
       chien2.setPoids(100)
        
        chien.sePresenter()
        chien2.sePresenter()
        dim p as decimal
        p=chien2.getPoids()
        System.Console.WriteLine("poids = " & p)
        'System.Console.WriteLine("le nom est " & chien.nom & " et il a le poids = " & chien.poids)
    End Sub
End Class
