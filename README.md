___
# Timberborn mod: output commandline options state to BepInEx log window.

## 内容
Timberborn.exe(vanilla)のコマンドラインオプションをBepInExのログウィンドウに一覧表示する。  
例：  
> [Info   : Unity Log] commandline option state:  
> [Info   : Unity Log]     Feature LongLastingCorpses: off  
> [Info   : Unity Log]     Feature Golems: off  
> [Info   : Unity Log]     Feature IgnoreScreenSettings: off  
> [Info   : Unity Log]     Feature NoSteam: off  
> [Info   : Unity Log]     Feature NewVersionValidationPrompt: off  


## 必要
BepInExPack Timberborn
> https://timberborn.thunderstore.io/package/BepInEx/BepInExPack_Timberborn/

## 動作確認バージョン
- Timberborn update1 Windows v0.1.1.1-db764df-gw
- Timberborn update1 Windows v0.1.5.2-773c83b-gw

## インストール
releaseフォルダ内のdllをBepInExのpluginsフォルダへコピーする。
___
# Timberborn(vanilla)のコマンドラインオプション
- 接頭辞：-feature-
  - 例：timberborn.exe -feature-Golems
- 機能名は大文字小文字を区別する。（Case sensitive）
