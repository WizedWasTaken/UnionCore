**KRAVSPECIFIKATION – FAGFORENINGSMEDLEMSKABSHÅNDTERINGSSYSTEM**

Kravspecifikationen opdeles i subsystems:

- **Subsystem 01: Lokalforeningernes hjemmesider**
- **Subsystem 02: Nyhedsbrev**
- **Subsystem 03: Kalender**

---

### **Subsystem 01: Lokalforeningernes hjemmesider**

**Aktører:**

- **System:** Platform til generering og visning af lokalforeningernes hjemmesider.
- **Administrator:** Ansvarlig for at administrere lokalforeningens hjemmeside.
- **Medlem:** Bruger af lokalforeningens hjemmeside.

**Funktionelle krav:**  
01. Hver lokalforening skal have en individuel hjemmeside med følgende:

- Lokalforeningens navn vises tydeligt på forsiden.
- Uddannelsesforbundets logo skal være synligt på forsiden.
- Dato for næste klubmøde skal vises på forsiden.

2.  Footer skal inkludere:

- Kontaktoplysninger på foreningsformanden (Navn, stilling, telefon og e-mail).
- Foreningens CVR-nummer.

3.  En liste over bestyrelsesmedlemmer skal vises på hjemmesiden.
4.  Den seneste nyhed fra lokalforeningen skal vises på forsiden.

---

### **Subsystem 02: Nyhedsbrev**

**Aktører:**

- **Administrator:** Ansvarlig for at oprette og sende nyhedsbreve.
- **Medlem:** Modtager af nyhedsbreve.

**Funktionelle krav:**  
01. Administratorer skal kunne oprette nyhedsbreve for deres lokalforening.  
02. Nyhedsbreve skal kunne sendes til alle medlemmer i lokalforeningen.  
03. Den seneste nyhed skal automatisk vises på lokalforeningens hjemmeside.

---

### **Subsystem 03: Kalender**

**Aktører:**

- **Administrator:** Ansvarlig for at oprette arrangementer.
- **Medlem:** Kan se kalenderen og deltage i arrangementer.

**Funktionelle krav:**  
01. Medlemmer skal kunne se en kalender med arrangementer for lokalforeningen.  
02. Administratorer skal kunne oprette nye arrangementer i kalenderen.

---

### **Ikke-funktionelle krav**

**Systemet skal overholde følgende ikke-funktionelle krav:**

1.  **Databasen:**

- Skal hostes på en Microsoft SQL Express Server 2019 på en lokal maskine.

2.  **Backend:**

- Skal udvikles i C# med Visual Studio 2022.
- Skal være en ASP.NET Core-applikation med .NET 8 som runtime.
- Skal kunne hostes på IIS Express til udvikling.
- Skal kunne deployes på en Windows Server 2019-maskine med IIS i produktion.

3.  **Frontend:**

- Skal udvikles i HTML5, CSS3 og JavaScript eller tilsvarende.

4.  **Browserkrav:**

- Hjemmesider skal kunne vises korrekt i Chrome, Edge og Firefox på Windows 10.
- Hjemmesider skal kunne vises korrekt i Safari på iOS og Chrome på Android.

5.  **Kommunikation:**

- Skal anvende HTTP eller HTTPS som protokol.
- Skal anvende JSON som dataformat.

**Bemærk:** Sikkerhed, GDPR og kryptering ligger uden for projektets mål og skal ikke implementeres i denne proof-of-concept. _Men giver bonus point_
