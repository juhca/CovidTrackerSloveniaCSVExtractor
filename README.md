# Slo Covid tracker CSV extractor

Kako zaženeš aplikacijo? 
Potegni dol realease, odpakiraj in zaženi exe.


Testiranje API:

### 1. Primer: 

https://localhost:5001/api/region/cases

- https://localhost:5001/api/region/cases?Region=mb&DateFrom=2020/05/05&DateTo=2020/05/20

Params:
- Region (LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA)
- DateFrom (2020/05/05, 2020-05-05, 2020.05.05, 05.05.2020, 05 May 2020, May 05 2020)
- DateTo (2020/05/20, 2020-05-20, 2020.05.20, 05.20.2020, 20 May 2020, May 20 2020)

### 2. Primer
https://localhost:5001/api/region/casesdb

- https://localhost:5001/api/region/casesdb?Region=mb&DateFrom=May 05 2020&DateTo=2020/05/20

Params:
- Region (LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA)
- DateFrom (2020/05/05, 2020-05-05, 2020.05.05, 05.05.2020, 05 May 2020, May 05 2020)
- DateTo (2020/05/20, 2020-05-20, 2020.05.20, 05.20.2020, 20 May 2020, May 20 2020)

### 3. Primer

https://localhost:5001/api/region/lastweek

### 4. Primer (avtentikacija)

https://localhost:5001/api/region/lastweekdb (potrebna avtentikacija) 

- https://localhost:5001/api/region/lastweekdb

V postmanu dodaj sledeč headers:
key: Authorization 
value: basic YWRtaW46MDAwMDAw // (base64 decode admin:000000)

