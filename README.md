# Adsetus Unity SDK
SDK Version: 1.0.9

## Overview
...

## Quick Start
### 1. Import Package
In the Unity Editor, select "Assets" -> "Import Package" -> "Custom Package".

### 2. Initialize SDK

```Java
Adsetus.Init("YOUR_APP_ID");	
```

### 3. Play an Ad

```Java
if (Adsetus.IsAdLoaded()) {
    Adsetus.ShowAd();
}
```
