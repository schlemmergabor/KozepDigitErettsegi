# 2023. őszi (október-november) digitális kultúra középszintű
# érettségi feladat megoldása
# (c) https://digiterettsegi.hu/

# tomegek néven lista -> értékek átmásolva a tomeg.txt-ből
tomegek = [16, 8, 9, 4, 3, 2, 4, 7, 7, 12, 3, 5, 4, 3, 2]

# kiírjuk a feladat sorszámát
print("2. feladat")

# össz tömeg kezdetben 0
ossz = 0
# bejárjuk a tömegek listát
for i in tomegek:
    # ossz-hez adjuk i. tömeget
    ossz += i

# kiírás    
print(f"A tárgyak tömegének összege: {ossz} kg")

print("\n3. feladat")

# csomagok darabszáma
db = 0
# össz kg (az aktuális csomagban
kg = 0

# kiírás, end="" -> jelentése ne legyen a végén enter/sortörés
print(f"A dobozok tartalmának összege (kg): ", end="")

# végig járjuk a tömegek listát
for i in tomegek:
    # ha az eddigi kg és a mostani nagyobb, mint 20
    if kg+i > 20:
        # kiírjuk az eddigi kg-t
        print(f"{kg} ", end="")
        # dobozok száma megnövelni
        db+=1
        # új doboz súlyát beállítani
        kg=i
    else:
        # minden más esetben
        # adjuk a dobozhoz a mostani súlyt
        kg += i

# utolsó doboz kiírása -> ami lehet nem teli is
print(f"{kg}")
# dobozok számának kiírása
# db+1 -> az utolsó akár nem teli doboz miatt
print(f"A szükséges dobozok száma: {db+1}")
    
