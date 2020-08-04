# OpenCV Témalabor
A témalabor célja megismerkedni az OpenCV (Open Computer Vision Library) képfeldolgozó osztálykönyvtár néhány képességével C++ vagy C# környezetben. Az OpenCV eredetileg robotikai, valós idejű alkalmazásokra készült, de azóta az egyik legszélesebb körben használt képfeldolgozási osztálykönyvtár lett. Színszűrések, elmosás, kontúrkeresés, képmorfológiai művelete (például dilatáció, erózió), mozgó objektumok keresése és követése, képszegmentáció, osztályozás… és még csomó más készen áll a használatra.
A témalabor keretében az alábbiakra fogunk kitérni:
OpenCV beizzítása, a közös projekthez git repository létrehozása (github.com)
Állókép vagy videó betöltése, mentése, megjelenítése, egyszerű rajzolás rájuk (Mat típus, imshow, videocapture, imread, imwrite)
Egyszerű szűrések, transzformációk (threshold, blur, erode és dilate)
Mozgó objektumok keresése (MOG2: Mixture of Gaussians Background Subtractor kipróbálása)
Képszegmentációs módszerek kipróbálása (Canny edge detector, MSER: Maximally Stable Extremal Regions)

# Technikai dolgok

### GitHub classroom
A GitHub classroomba ha regisztrálsz, akkor a kiindulási repositoryról kapsz egy saját változatot (private repo, más nem látja), ahova tudsz dolgozni. Így tudjuk követni az előre haladást. Kérlek, hogy a repositoryba rendszeresen pushold a változásokat, hogy lássuk, ki hogy halad.

A Github classroom meghívó linket kockázatos itt megosztani, de bárkinek szívesen elküldöm.

### Feladatok leadása, határidők
Minden héten az elkészült feladatokat github pull request formájában adjátok le, legkésőbb a hét végéig. Ha a valós adatok irányát választjátok, a pull request leírásába tegyetek be egy kimeneti képet vagy screenshotot is, hogy lássam, milyen lett az eredmény. (Nyugodtan írhatsz hozzá pár mondatot is, ha van valami hozzáfűzni való.)

### Kommunikáció
Ebben a félévben kísérleti jelleggel nem egy levlistát fogunk használni, hanem Slacket, mint az iparban ilyen célra leginkább elterjedt kommunikációs platformok egyikét. A csoport meghívásos jellegű.

A Slack arra van, hogy kérdezzetek rajta, osszátok meg, hogy miket találtatok. Nem egyedül kell rájönni mindenre, de azért ne is oldjátok meg egymás helyett a feladatokat. Ja és nem csak egy helyes megoldás van! Ha valamit nem tudtok eldönteni, válasszátok a logikusabbnak tűnő megoldást. Aztán utána megbeszéljük, ki mire jutott.

### Unit teszt alapú és "valódi adatok" irányvonal
A lentebb olvasható heti feladatokból két féle van: az egyik egy unit teszt alapú, többnyire generált gépeken dolgozó irányvonal, a másik egy valós projektekből vett anyagokon dolgozik. Bármelyik héten bármelyiket választhatod. Amelyik szimpatikusabb. A unit teszt alapú megoldásnál a tesztek ellenőrzik, hogy jól oldottad-e meg a feladatot. A valódi adatsorokra ilyenek nincsennek, ott neked kell a futási eredmény alapján felmérni, hogy jó lett-e a megoldás.

### Real World Track

Ezen kívül ha van kedved összetettebb feladatokkal foglalkozni, ennek a heti feladatok után találsz összetettebb feladatokat (Real World Track), amik több hétig kitartanak és ezekkel akármelyik heteket helyettesítheted, csak előre jelezd, hogy most nem a standard heti feladattal szeretnél foglalkozni.

### Unit tesztek
A unit teszt alapú feladatokhoz a kiindulási repositoryban egy kis keretprogram található, valamint egy csomó unit teszt. A feladatok elkészítése során a funkciók egy részét ezek a unit tesztek is ellenőrzik (de nem mindent). A félév során egyrészt ezeket a unit teszteket kell "bezöldíteni". Az elején minden unit teszt előtt van egy "Ignore" attribútum, hogy ne jelezzen hibát, ezeket természetesen el kell távolítani, amint a megoldásodat tesztelni szeretnéd. (Visual Studio alatt a Test Explorerben tudod lefuttatni a solution minden unit tesztjét. Ha esetleg itt semmi nem jelenik meg, fordítsd le a projektet és ellenőrizd, hogy a Teszt menüben a processzor architektúra ugyanarra van-e beállítva, mint amire a projekteket fordítod, pl. x64-re.)

Amellett, hogy a már adott unit teszteket bezöldíted, a feladat része az is, hogy te is gyakorold a megoldásod helyességének ellenőrzését. Ezért arra kérlek, hogy minden egyes feladathoz te magad is készíts 2-3 további unit tesztet, hogy minél alaposabban körbe legyen tesztelve az adott kódrészlet.
 (Ipari környezetben fontos, hogy az ember maga győződjön meg, hogy a megoldása helyes, még mielőtt kiadja a kezéből. Az "OK, javítgattam rajta, most már elegendően jó?" megközelítés ott már nem működik: a kredit megszerzéséhez elég a kettes, de a munkahely megtartásához az ilyen megoldás nem lesz elegendő... vagy ha igen, az olyan cégnél szerintem akarsz dolgozni, mert a kollégáktól is csak olyan minőséget fogsz kapni a csapatmunkában, ami csak éppen hogy elegendő.)

Van egy unit teszt, ami már rögtön az elején zöld, ezzel tudod ellenőrizni, hogy a fejlesztő környezet készen áll-e az indulásra: TestIntro

A feladatok során a fő hangsúly a unit teszteken van: ha azok zöldek, akkor minden OK. Vagyis nem kell feltétlenül minden feladathoz futtatható programot készíteni, elég, ha a ...Task végű osztályok tartalmát megírod úgy, hogy a unit tesztek zöldek legyenek. A unit teszt ilyen szempontból a programot helyettesíti: ugyanúgy tudod egyesével futtatni őket, debuggolni (jobb klikk a unit teszten a test explorerben). Ilyenkor a heti feladat megoldásához nem is szükséges új könyvtárat vagy projektet létrehozni, simán dolgozz a "Solutions" könyvtárába az Intro projektnek.

De ha egy feladathoz nincsen unit teszt (például a félév elején lévőkhöz nincs), vagy ki szeretnéd egészíteni valami extrákkal, nyugodtan készíts hozzá egy új projektet, ami hivatkozik (Add reference...) az Intro-ra és akkor tudja hívni a benne lévő ...Task osztályokat.

# Feladatok hétről hétre
Az első 2 héten közös előadások vannak, addig nincsen OpenCV-s feladat, bár ha van kedved, természetesen előre is dolgozhatsz. A feladatok egy részéhez kicsit utána is kell olvasni a dolgoknak (pl. az eróziónak, mint képmorfológiai művelet), ilyenkor a Google és az OpenCV dokumentáció egy jó kiinduló pont. Ha pedig megakadsz vele, szólj!

A heti feladatok leírásában külön szerepel (általában tömörebben leírva), hogy a valós adatokat választók számára mi a feladat. Ezek megoldása sokban hasonlót a unit teszt alapú irányban szereplőkhöz, így azokból mindig lehet ihletet és tippeket meríteni.

## 3. Hét: Bevezető
OpenCV beizzítása C# alatt, webes dokumentáció (OpenCV 3.0) megkeresése, belenézés.
GIT repository beüzelemése (github classroom regisztráció), mindenkinek saját private repositoryja lesz az opencvtemalabor organization alatt. Ebbe dolgozzatok a témalabor keretében.
Feladat: írjatok egy kis programot, mely parancssori paraméterként kap két fájlnevet (egy létező képet és egy kimeneti képfájlt), ezt betölti, rajzol neki egy sárga keretet, majd elmenti a 2. paraméterként kapott néven.
https://youtu.be/aYuXU1p8u20

Kapcsolódó unit tesztek: TestIntro (Már alapból zöld, ha a fejlesztő környezet működik.)

## 4. Hét: Videó megnyitása, elmentése
Készítsetek egy programot, mely megnyit egy videó fájlt (ha van kamerátok, azt is használhatjátok a feladathoz és akkor élő képpel dolgozik majd), rárajzol egy ellipszist minden képkockára és megjeleníti őket. (A képkockák között vár, hogy meglegyen a 25FPS.) Emellett az elkészült videót el is menti egy videó fájlba.
(A szükséges funkciókhoz kelleni fog egy kis dokumentáció keresés, stackoverflow és társai.)

Kapcsolódó unit teszt: még nincsen. Viszont ehhez a feladathoz már lehet készíteni sajátot. Ebben a feladatban és a továbbiakban is törekedjetek rá, hogy megoldásotoknak megfelelő teszt lefedettsége legyen. Például az ellipszis rárajzoló függvényre lehet írni egy tesztet, hogy ha kap egy fekete képet, akkor azon tényleg megjelenik-e elegendő (hihető mennyiségű) ellipszis-színű pixel. Meg esetleg egy-két konkrét pixelre lehet tesztelni, hogy ott az a szín van-e, aminek lennie kell. Tudom, ez nem szuperbiztos teszt, de valamennyi hibát már ez is meg tud fogni.

**Valós adatok:** Alternatív feladatként készíthetsz egy textúra rajzolást segítő alkalmazást. A textúra lényege, hogy többször egymás mellé másolva folytonos a mintája, vagyis nem látszanak a szélén az illesztések. Ennek megrajzolását úgy lehet segíteni, hogy a képet negyedeled és minden negyedet áthelyezel az átlósan átellenes oldalra. Így egy olyan képet kapsz, amin középen vannak a kiszépítendő illesztések. Ezt egy rajzprogramban kijavítgatva, elmosva, árrajzolva, majd a negyedeket ugyanezzel a programmal visszacserélve egy olyan képet kapsz, aminek a szélei is illeszkednek. A megvalósítás pár másolást igényel, amire jó a Mat osztály copyTo metódusa, valamint érdemes tudni, hogy egy Mat által leírt kép egy részletére létre lehet hozni egy másik Mat-ot, ami sima kép, de valójában egy nagyobb kép egy részlete. Vagyis ha értéket adsz neki vagy másolod, azt az eredeti nagy kép egy részletével (is) teszed.

## 5. Hét: Foltok megszámolása
Írj egy programot, mely megszámolja, hogy egy képen hány összefüggő folt van. A kis szakadások eltűntetéséhez először válaszd ki a fehér részeket, azokat dilatáld, majd számold meg őket. A számolás alapja a floodFill: kezdetben a háttér legyen mindenhol fekete “0”, az előtér “255”. Ezután indulj el a bal felső sarokból pixelenként, és ha egy pont 255, akkor abból a pontból kiindulva a floodFill segítségével színezd át minden pontját 0-ra, és növeld a számlálót 1-gyel. A képen végig érve minden fekete lesz és a számláló az eltűntetett foltok számát jelzi. (Látványosabb megoldás, ha eltérő színűre színezed a foltokat és akkor utána érdemes meg is jeleníteni.) (Vannak unit tesztek, amik összefüggő komponensnek tekintik a hátteret is, vagyis az is egy (vagy lyukas alakzatok esetén több) folt!

A floodFill esetében mindig fontos kérdés a connectivity: egy pixelnek 4 vagy 8 szomszédja van? A unit tesztek 8-as connectivityt feltételeznek, vagyis egy átlós, 1 pixel széles vonal nem vág ketté foltokat, mert a pixelei között átlósan még "átfolyik" a festék.

Miután megvan minden összefüggő folt, határozd meg a bennfoglaló téglalapjukat (mindnek együtt a közös bennfoglaló téglalapot)!
Nagyon figyelj rá, hogy az OpenCV alatt a Mat pixeleinek indexelése ha nem pl. Point típussal történik, akkor sor-oszlop sorrendben következik, vagyis pl. a generic indexer esetében [y,x]! (Pixelek elérése gyorsan: https://github.com/shimat/opencvsharp/wiki/%5BCpp%5D-Accessing-Pixel)

Kapcsolódó unit tesztek (és a további, sajátokat is ide írd meg): TestBoundingBox

További unit tesztek: TestConnectedComponents (Ezek még nem használják a dilatációt és eróziót, viszont a hátteret is egy, vagy lyukak esetében több foltként számolják bele a darabszámba.)

**Valós adatok:** Alternatív feladatként egy kapott homokkő vékonycsiszolat képen számold ki a (kék gyantával feltöltött) pórusok területének arányát, valamint a pórusok átlagos területét. Erre többek között régészeknek és restaurátoroknak van szüksége, mert ha túlságosan porózus egy homokkő, akkor bár könnyen ki lehet belőle faragni egy szobor hiányzó darabját, de túlságosan málékony lesz és kültéren 2-3 év múlva tönkre megy.

## 6. Hét: kép morfológia, távolságok
Ezen a héten két feladat van: az egyik az erózió és dilatáció, mint képmorfológiai művelet megismerése, melyek a foltokat kicsinyítik és növelik, a másik pedig a distance transform megismerése, mely minden pixelre meghatározza, hogy attól milyen messze van a legközelebbi fekete pont (pl. bináris kép esetén a fehér pontokra megmondja, hogy milyen messze van a legközelebbi fekete, ami egyben az oda mint középpontba beírható maximális kör sugara is).

A feladat során téglalapok belsejében határozzuk meg a fekete "falaktól" mért távolságokat. A tesztek a maximális távolságokat keresik, ami helyes megoldás esetén a téglalap közepén lévő pixelek listája.

Kapcsolódó unit tesztek (a további, sajátokat is ide írd meg): TestConnectedComponents, TestDistanceMap

**Valos adatok:** Ezen a héten az alternatív feladat egy kapott (vagy általad rajzolt) bináris térképen (csak fekete és fehér színek) azoknak a helyeknek a meghatározása, ahol egy ismert r sugarú kör alakú robot középpontja még lehet. Vagyis a distance transform segítségével színezd ki azokat a pontokat a térképen, amik minden akadálytól legalább r távolságra vannak. Robotok pályatervezésénél szokták ezt a trükköt gyakran használni, mivel az így kapott térképen már pontszerűnek is tekinthetjük a robotot, a valóságban nem fog nekimenni semminek.

## 7. Hét: Mozgó objektumok keresése
A MOG2 háttéreltávolító algoritmus segítségével egy videón keresd meg a mozgó részeket és úgy jelenítsd meg a videót. (Kiegészítő feladat: a bal felső sarokban jelenítsd meg az 500 pixelnél nagyobb foltok számát.)

Kapcsolódó unit tesztek (a további, sajátokat is ide írd meg): TestMotionTracking

Kicsit részletesebben a tesztek működése:

`Intro.TestImageGenerators.MotionTrackingAnimation.Motion` egy polygont tárol (ez lesz a mozgó alakzat), ami vezérlőpontokon ugrál végig (`MotionAnchorLocations`). A `MotionTrackingAnimation` ilyenekből tárol többet (`MotionTrackingAnimation`,`allMotions`). Mindig van egy aktuális közöttük (`currentMotion`), amire az `AddPoint` és hasonló "építő" metódusok vonatkoznak, vagyis amit még éppen most rakunk össze.
A teszábra generátornak mindig össze kell rakni ilyen `Motion` példányokat, majd el lehet kérni az egyes képkockákat, amikre mindet szépen rárajzol. (Pl. egy két vezérlőpont között átmenő piros téglalap).
A `TestMotionTracking.GenerateSingleMotion_Line` egy téglalapot (`var shape = GenerateRectangleAsPolygon()` fog végigmozgatni az `A` és `B` pont között (`AddLine` segítségével adja meg a köztes anchorLocation-öket). Majd az `assertDetection` tudja, hogy a `Motion`-nek éppen egy adott képkockán hol kell lennie, így tudja ellenőrizni, hogy az általatok megírandó detektor abban a pozícióban találta-e meg, ahova azt tényleg rajzoltuk.

(Sajnos a MOG2 algoritmus a mostani OpenCvSharp alatt kicsit gyengélkedik, így lehet, hogy ez a feladat most kimarad.)

**Valós adatok:** Ezen a héten egy olyan programot készíts, ami a MOG2 algoritmus segítségével egy közúti forgalomról készített (fix kamerás) videón bejelöli (kiszínezi) az autók aktuális helyét. Ha van kedved, forgalomszámlálás irányba is tovább fejlesztheted.

## 8. Hét: Képszegmentációk
A Canny élkereső algoritmus segítségével keresd meg az éleket egy videó minden képkockáján, majd jelenítsd meg az él-pixelek arányát a képen és így jelenítsd meg az “él-videót”. Részletgazdag képet nézve az arány magas lesz, homogén felületek felé forgatva a kamerát (ha kamerát használsz és nem videót) kicsi szám lesz.

Kapcsolódó unit tesztek: még nincsen

**Valós adatok:** Kapott kőzet vékonycsiszolat képeken próbáld meghatározni a szemcsék határvonalait. Ehhez lehet használni a Canny algoritmust és a findContours metódust. Írd ki a talált szemcsék számát és rajzold be a képre a megtalált határvonalakat.

## 9. Hét: felhasználói interakció, rajzolás pixelenként
Feladat: készíts egy programot, melyben az egérrel lehet rajzolni. Lehet benne színkiválasztás is, például az R, G és B billentyűkkel…

Kapcsolódó unit tesztek (a további, sajátokat is ide írd meg): TestDrawing

**Valós adatok:** Készíts OpenCV alapokon egy kis alkalmazást, melyben egérrel ki lehet jelölni egy videón (mármint egy képkockáján) 2 pontot. Ez lesz az úgynevezett scanline. Ezután gombnyomásra generálj le egy olyan képet, aminek a magassága megegyezik a scanline hosszával, a szélessége pedig a videó képkockáinak számával. Minden képkockából úgy készítsd el a következő pixel oszlopot, hogy a scanline pixeleit oda másolod. Így pl. egy közúti forgalomról készült videóból ha generálsz egy ilyen un. spatiotemporal képet úgy, hogy az autók áthaladnak a scanlineon (vízszintes tengely az idő lesz, a függőleges a hely a scanline mentén), a kapott képen egész jól meg lehet számolni a járműveket.

## 10. Hét: Folt mérethisztogram
Egy foltos képen a foltokról méret-hisztogram készítése és kirajzolása (akár a videó képre rárajzolt oszlopdiagram formájában is.) Kőzetek, ötvözetek, vagy légifelvételek elemzésénél gyakran szükség van ilyesmire. A tesztek egy csatornás (CV_8UC1) képet feltételeznek, amiben 0 a háttérszín és 255 a foltok színe.

Kapcsolódó unit tesztek (a további, sajátokat is ide írd meg): TestBlobSizeHistogram

**Valós adatok:** Egy kapott, gyógyszergyártás során használt granulátum lezuhanó szemcséit tartalmazó videón határod meg a szemcseméret hisztogrammot. A megfelelő méretű szemcsék fontosak a tabletták préselése során, így ha ez a szemcseméret hisztogram valamiért megváltozik, a gyógyszerek minősége érdekében azonnal be kell avatkozni a granulálási folyamatba.

## 11. Hét: Turkmesz, Langton hangyája, vagy Turmit
A turkmesz egy kis véges állapotú automata jószág, ami egy képen mozog aszerint, hogy milyen színű az alatt álló pixel. Fekete-fehér kép esetén például a legegyszerűbb eset (ami most a feladat is) fekete pixelen állva azt fehérre színezi, balra fordul és megy előre egyet; fehér pixel esetén pedig feketére festi, jobbra fordul és úgy megy előre egyet. Egy idő után érdekes mintázatot fog kirajzolni. (Ha megvan, küldj rója egy screenshotot a levlistára! :) ) (A mozgási szabályok kommentárként szerepelnek a TurkmeszTask osztály kódjában.)
(https://en.wikipedia.org/wiki/Langton%27s_ant)

Kapcsolódó unit tesztek (a további, sajátokat is ide írd meg): TestTurkmesz

**Valós adatok** feladat ehhez a héthez nem tartozik. Cserébe ha van kedved, készíts egy szép Turkmesz képet valami speciális mozgási szabállyal és postold be a Slackre, hogy lássuk, kié lesz a legszebb! Ki tervezi a legcselesebb mozgási szabályt? :)

## 12.-13. Hét: saját feladat
Mindenkivel egyeztetünk egy saját, kedvére való kisfeladatot, amit elkészít. Néhány példa:

  * Mandelbrot halmaz megjelenítő program
  * Videó vágó program: előre-hátra lehet benne mozogni egy videóban és meg lehet neki adni, hogy hol vágja szét darabokra. Utána akár ki is lehet egészíteni, hogy a darabolás után másik sorrendben össze is tudja rakni a darabokat. Vagy csak mentse el őket külön-külön.
  * Kamerás mozgásérzékelő alkalmazás fejlesztése, ami bizonyos méretű mozgó objektum esetén riaszt. (Ki lehet egészíteni úgy, hogy ha a mozgó objektumban sok egy adott szín, akkor mégsem riaszt. Pl. láthatósági mellényben be lehet menni… :) )
  * Jellegzetes színű pont (pl. LED) mozgásának követése a videó képen. (Ki lehet egészíteni úgy, hogy villog a LED, amitől egyértelműbb a felismerés. De akár egy kódot is levilloghat, mint a tanszéki 5G Konvoj autói.)

Ezekhez a feladatokhoz nincsennek unit tesztek, viszont te készíts ezekhez is néhányat!

## 14. Hét: befejezés, konklúziók
Közösen megnézzük az eredményeket, megbeszéljük a tapasztalatokat.

# Real World Track

Az OpenCV témalabor eredeti feladatsora (lásd README.md) mellett lehetőség van arra, hogy a vállalkozó kedvűek olyan feladatokkal foglalkozzanak, ami kevésbé absztrakt, bevezető jellegű, helyette sokkal közelebb van a "hétköznapi feladatokhoz". Természetesen a két út között váltani is lehet, nem kell előre eldönteni, hogy melyiken haladsz, csak választásodat jelezd előre.

Az alábbi feladatok közül annyit válassz, hogy minden hétre legyen vagy a fentiekből, vagy innen feladat.

## Kaleidoszkóp

- Időigény: 2 hét
- Alaptechnológia: videó beolvasás, remap függvény

A feladat egy olyan program készítése, mely egy tetszőleges videóból egy olyan videót készít (vagy csak megjelenít), mintha egy kaleidoszkópon keresztül néznénk az eredetit.

A kaleidoszkóp előre meghatározott egyenesek mentén tükrözi a képet. A remap függvény számára minden pixelre meg lehet adni, hogy mely pixelből másolja oda a színt, így a leképezést előre kiszámítva a videó egyes képkockáin ezt már nagyon gyorsan végre tudja hajtani.

## Harry Potter hopponálás

- Időigény: 3 hét
- Alaptechnológiák: videó beolvasás, háttéreltávolítás (két kép különbségével, chroma key vagy MOG2 módszerrel), remap, maszkolás

A Harry Potter filmekben a hopponálást lehetne úgy utánozni, hogy egy rögzített kamerával felveszünk alakit, de úgy, hogy előtte csak a hátteret vesszük fel, majd az ehhez viszonyított eltéréssel megkeressük a szereplőt. Ezeket a pixeleket egy a kaleidoszkóp feladathoz hasonlóan a remap segítségével egy szűkülő spirál mentén "forgatjuk" befelé.

## Varázspálcával írás a képre

- Időigény: 2 hét
- Alaptechnológiák: thresholding, HSV színrendszer, cvtColor

Tanító videó készítésnél hasznos, ha szemben állva a kamerával egy kezünkben tartott varázspálca hegye nyomot hagy a videó képen (pl. 5 másodpercig). Ehhez az kell, hogy a varázspálca vége jellegzetes és könnyen megtalálható színű legyen. A program minden képkockán megkeresi ezt a foltot, és a következő valahány képen.

## Forgalomszámlálás

- Időigény: 3 hét
- Alaptechnológia: MOG2, floodfill (összefüggő foltok keresésére)

A forgalomszámlálás elég nagy szakterület, de a MOG2 háttéreltávolító algoritmust nagyon jól lehet használni felülnézeti képek esetén. Érdemes először olyan videóval kezdeni, amin a felülnézet miatt a járművek között végig látható az útburkolat, vagyis nincsennek átfedések, takarások.

A megoldáshoz készíts például az egyik budapesti hídról egy stabilan tartott telefonnal egy videót, ahogy alattad átmennek az autók. (Szabadság híd, Erzsébet híd kiváló erre.) Nézz utána, hogyan működik (nem csak mit csinál!) a MOG2 algoritmusa az OpenCV-nek és üzemeld be a videóra, majd számold meg, hány összefüggő folt mozog a videón.

## Kamera kalibráció és 3D helymeghatározás

- Időigény: 2 hét
- Alaptechnológiák: kamera kalibráció, háromszögelés

Két kamerát sakktáblával kalibrálva minden kamerára meg lehet határozni, hogy hozzá képest egy objektum (pl. feltűnő színű labda) merre van. Ha ismerjük a két kamera helyét (a kalibráció meg fogja ezt adni a sakktábla minta koordináta rendszerében), akkor az ezekből indított félegyenesek metszéspontjában van az objektum. Így lehet két kamerával 3D pozíciót meghatározni. A feladat ennek kipróbálása, beüzemelése.

[https://docs.opencv.org/master/dc/dbb/tutorial_py_calibration.html](https://docs.opencv.org/master/dc/dbb/tutorial_py_calibration.html)

## Fotó vagy videó vízjelezése

- Időigény: 1 hét
- Alaptechnológiák: alpha blending (képek súlyozott összeadása), színrendszerek (főleg HSV)

A vízjel lehet például egy felirat vagy másik kép, amit egy videó minden képkockájára rákeverünk. Lehet súlyozott összeadással, vagy úgy is, hogy HSV színtérben a vízjel helyén a Value értéket (világosság) lecsökkentjük az érintett pixeleken. (De egyébként számos más transzformációt is el lehet képzelni... például milyen, ha a Hue értéket forgatjuk el egy kicsit a vízjel által érintett pixeleken.)

## Folytonos textúra készítést segítő program

- Időigény: 1 hét
- Alaptechnológiák: Mat másolása, RoI használata (Region of Interest, a kép egy téglalap alakú részlete, amit a Mat el tud tárolni.)

Ha valaki folytonosan csempéző textúrát szeretne rajzolni, akkor a határokon látható egyenes "illesztési hibát" úgy lehet könnyen lekerülni, hogy a texúra megrajzolása után negyedeljük (függőlegesen és vízszintesen is felezve), minden negyedet áthelyezzük az átlósan túloldalra és elmentjük a képet. Ezen rajzprogrammal javítva, a határokat elsimítva olyan textúrát kapunk, aminél nem látszanak majd az illesztési hibák.
