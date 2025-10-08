# Calcul API

Une API simple en .NET 6/7 pour effectuer des opérations de calcul : addition, soustraction, multiplication et division.

---

## Dépôt GitHub

Le projet est disponible sur GitHub :  
```
git remote add origin https://github.com/themedworld/CalculeApp.git
```

---

## Endpoints et Exemples

| Méthode | Endpoint                    | Description                     | Paramètres | Exemple d'appel | Résultat |
|---------|----------------------------|---------------------------------|------------|----------------|----------|
| GET     | `/api/calcul/add`           | Addition de deux nombres       | `a`, `b`  | `/api/calcul/add?a=2&b=5` | `7` |
| GET     | `/api/calcul/sub`           | Soustraction de deux nombres   | `a`, `b`  | `/api/calcul/sub?a=10&b=3` | `7` |
| GET     | `/api/calcul/mul`           | Multiplication de deux nombres | `a`, `b`  | `/api/calcul/mul?a=4&b=5` | `20` |
| GET     | `/api/calcul/div`           | Division de deux nombres       | `a`, `b`  | `/api/calcul/div?a=10&b=2` | `5` |

💡 **Attention** : la division par zéro renvoie une erreur `400 Bad Request`.

---

## Installation et Git

1. Cloner le dépôt :

```bash
git clone https://github.com/themedworld/CalculeApp.git
cd CalculeApp
```

2. Initialiser Git et ajouter le remote (si pas déjà fait) :

```bash
git init
git remote add origin https://github.com/themedworld/CalculeApp.git
```

3. Ajouter tous les fichiers et créer un commit :

```bash
git add .
git commit -m "Initial commit: ajout du projet Calcul API"
git push -u origin main
```

4. Restaurer les dépendances :

```bash
dotnet restore
```

5. Lancer l'application :

```bash
dotnet run
```

L’API sera disponible sur `http://localhost:5004`.

---

## Tester avec Swagger

Swagger est intégré pour tester facilement tous les endpoints.

- **Localement** :  
  [http://localhost:5004/swagger](http://localhost:5004/swagger)

- **Sur Render** (après déploiement) :  
  ```
  https://TON_APP.onrender.com/swagger
  ```

### Étapes pour tester

1. Cliquer sur un endpoint (ex : `GET /api/calcul/add`).  
2. Cliquer sur **“Try it out”**.  
3. Entrer les valeurs pour `a` et `b`.  
4. Cliquer sur **“Execute”** pour voir la réponse JSON.  

**Exemples de calcul :**

- Addition : `/api/calcul/add?a=8&b=12 → 20`  
- Soustraction : `/api/calcul/sub?a=15&b=4 → 11`  
- Multiplication : `/api/calcul/mul?a=6&b=7 → 42`  
- Division : `/api/calcul/div?a=20&b=5 → 4`  
- Division par zéro : `/api/calcul/div?a=10&b=0 → Erreur : division par zéro`

---

## Déploiement sur Render

1. Créer un **Web Service** sur [Render](https://render.com/) et connecter ton dépôt GitHub.  
2. Branche : `main`  
3. Build Command :

```bash
dotnet publish -c Release -o ./publish
```

4. Start Command :

```bash
dotnet ./publish/MonApi.dll
```

Ton API sera disponible via une URL publique, par exemple :  
```
https://calculapi.onrender.com/api/calcul/add?a=2&b=5
```

Et pour tester via Swagger :  
```
https://calculapi.onrender.com/swagger
```

---

## Auteur

- **Trai Mohamed Amin:)**  
- GitHub : [themedworld](https://github.com/themedworld)

