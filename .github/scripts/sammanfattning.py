"""Gör om testresultaten (TRX-filer) till en tabell som visas i GitHub Actions."""
import glob
import os
import re
import sys
import xml.etree.ElementTree as ET

mapp = sys.argv[1] if len(sys.argv) > 1 else "testresultat"
filer = sorted(glob.glob(os.path.join(mapp, "**", "*.trx"), recursive=True))

print("## Resultat för autorättningen\n")

if not filer:
    print("❌ **Koden gick inte att kompilera**, så inga tester kunde köras.\n")
    print("Öppna steget *Kör testerna* ovan och leta efter raden med `error`.")
    sys.exit(0)

resultat = []
for fil in filer:
    for element in ET.parse(fil).iter():
        if element.tag.endswith("UnitTestResult"):
            meddelande = ""
            for barn in element.iter():
                if barn.tag.endswith("Message") and barn.text:
                    meddelande = barn.text.strip().splitlines()[0]
                    break
            resultat.append((element.get("testName", "?"), element.get("outcome"), meddelande))

# Naturlig sortering, så att "Uppgift 10" hamnar efter "Uppgift 9".
resultat.sort(key=lambda r: [int(d) if d.isdigit() else d for d in re.split(r"(\d+)", r[0])])
godkanda = sum(1 for _, utfall, _ in resultat if utfall == "Passed")

if resultat and godkanda == len(resultat):
    print(f"### 🎉 Alla {len(resultat)} tester är godkända!\n")
else:
    print(f"### {godkanda} av {len(resultat)} tester godkända\n")

print("| | Test | Kommentar |")
print("|---|---|---|")
for namn, utfall, meddelande in resultat:
    ikon = "✅" if utfall == "Passed" else "❌"
    if utfall == "Passed":
        meddelande = ""
    elif "NotImplementedException" in meddelande:
        meddelande = "Inte påbörjad ännu"
    meddelande = meddelande.replace("|", "\\|")
    print(f"| {ikon} | {namn} | {meddelande} |")
