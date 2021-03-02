Imports System
imports System.Collections.Generic
'https://github.com/mehdiTmimi/vb
Public Class Test
  
  public class Etudiant
        private cne as String
        private nom as String
        private prenom as String
        private promo as Promo
        'getters and setters
        public sub setNom(val as String)
            nom=val
        end sub
        public function getNom() as String
            return nom
        end function

        public sub setPrenom(val as String)
            prenom=val
        end sub
        public function getPrenom() as String
            return prenom
        end function

        public sub setCne(val as String)
            cne=val
        end sub
        public function getCne() as String
            return cne
        end function

        public sub setPromo(val as Promo)
            promo=val
        end sub
        public function getPromo() as Promo
            return promo
        end function

  end class
  
    public class Promo
        private nom as String
		private etudiants as List(of Etudiant)


        public sub setNom(val as String)
            nom=val
        end sub
        public function getNom() as String
            return nom
        end function

        public sub setEtudiants(val as List(of Etudiant))
            etudiants=val
        end sub
        public function getEtudiants() as List(of Etudiant)
            return etudiants
        end function
    end class

    Public Shared Sub Main()
		'des declarations
		dim et1 as Etudiant
		dim et2 as Etudiant
		dim promo as Promo
		
		et1 = new Etudiant()
		et1.setCne("10212312312")
		et1.setNom("tmimi")
		et1.setPrenom("mehdi")
		
		et2 = new Etudiant()
		et2.setCne("143242434")
		et2.setNom("bennani")
		et2.setPrenom("hamza")
		
		promo=new Promo()
		promo.setNom("IG 2021")
		
		et1.setPromo(promo)
		et2.setPromo(promo)
		
		promo.getEtudiants().Add(et1)
		promo.getEtudiants().Add(et2)
		
		
    end sub
End Class