Covid19 Teszt

Az általam készített szoftver célja, hogy megállapítsa egy adott emberről, hogy koronavírusos-e vagy sem.

A felhasználói felületen látható 'Teszt kitöltése' gombra kattintva megkezdődik a szűrő teszt kitöltése, amelyhez először az életkorod kell megadni, majd a nemed, ezek után pedig válaszolnod kell 5 darab kérdésre, melyek rendre:

	Jártál-e külföldön az elmúlt 14 napban?
	Érintkeztél koronavírusos beteggel az elmúlt 14 napban?
	Tapasztaltál-e magadon koronavírusra utaló tüneteket?
	Megszegted-e a kormány által megszabott korlátozásokat?
	Rendelkezel pozitív PCR teszttel?
	
Ha a fent említett kérdések közül bármelyik háromra (vagy többre) igen a válasz, akkor potenciális fertőzött vagy. (Természetesen, a szűrés eredménye nem reprezentatív)
	
A szoftveremhez készítettem egy csv fájlt, amiben a tesztet már korábban kitöltő (fiktív) emberek válaszai találhatók. A teszt ellenőrzése után, az újonnan felvett adatok is belekerülnek a csv fájlba.

A felhasználói felületen látható 'Diagram' gombra kattintva egy új formon megjelenik egy diagram és a hozzá kapcsolódó adatok egy DataGridView-ban (amik először üresen jelennek meg). A felhasználó a 'Férfiak és a 'Nők' gomb megnyomásával megjeleníthetik a diagramon, hogy az adott nem közül hányan lettek pozitívak, illetve negatívak a tesztet kitöltők közül.








