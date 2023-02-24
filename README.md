# サバイバルゲーム
ゲーム制作で使用するプログラムを保管<br><br>

<h3>開発言語</h3>
C#<br><br>

<h3>フレームワーク</h3>
Unity<br><br>

<h3>開発背景</h3>
ハマってたサバイバルゲームがDSの破損により遊べなくなったためそれっぽく実現しようとしている。<br><br>
とりあえずで手を出してみたが意外とハマった。たまに作るくらいなら続けられそう。<br><br>

<h3>状況</h3>
現時点で実装済
<ul>
  <br>
  <li>方向Keyでキャラクターを操作</li><br>
  <li>「c」Keyでしゃがむ</li><br>
  <li>「e」Keyでアイテムを拾う</li><br>
  <li>「q」Keyでアイテムポーチを開く</li><br>
  <li>アイテムポーチでアイテムをクリックするとアイテム使用</li><br>
</ul>

今後実装予定
<ul>
  <li>HPの概念</li><br>
</ul>


ステージ<br><br>
<img width="1280" alt="image" src="https://user-images.githubusercontent.com/116938721/220808961-35f000ba-c98e-48e2-8fd2-046f045c84ef.png">
<br><br>

フィールド<br><br>
![11](https://user-images.githubusercontent.com/116938721/220808022-047e2301-edc5-4925-b22d-eb73f2ca484a.jpg)
<br><br>

アイテムポーチ(最後に4個→12個にする予定)<br><br>
![3](https://user-images.githubusercontent.com/116938721/220807732-72442e8a-abcd-4e86-9031-97dc863bdf1a.jpg)
<br><br>

動作確認 (キャラクターを動かす)<br>
<a href="https://user-images.githubusercontent.com/116938721/220811352-4becb518-a2e0-4fd1-ac1d-a8311e2cc1c9.mp4">動作確認1</a><br>
<a href="https://user-images.githubusercontent.com/116938721/220811894-e66bd712-b209-44a7-895c-9a5440a235ea.mp4">動作確認2</a><br>
<a href="https://user-images.githubusercontent.com/116938721/220812515-87dd6166-3064-431d-98f0-a775509531fb.mp4">動作確認3</a><br>
↓<br>
段差のならし方が粗い箇所でのジャンプが若干ぎこちない<br><br>

動作確認 (アイテムを拾う)<br>
<a href="https://user-images.githubusercontent.com/116938721/221113346-e926666c-ce4b-44af-b7f1-e3b2822e5a4d.mp4">動作確認</a><br>
↓<br>
初期状態のアイテムポーチは空でアイテムも無いので <font color="red">空白 : 0</font> になっている。<br>
ココナッツを拾ったところでアイテムポーチにココナッツが追加され、<font color="red">Coconut : 1</font> になる。<br>
アイテムポーチを開いている状態でココナッツの画像を押すとココナッツを使用。<br>
アイテム使用時の効果は HP 実装後に追加予定。現時点ではアイテム効果に0を代入している。<br><br>


<h3>参考文献</h3>
<ul>
  <li><a href="https://gametukurikata.com/program/scriptableobjectitemdatabase">UnityでScriptableObjectを使ってアイテムデータベースを作成する</a></li>
  <br>
  <li><a href="https://gametukurikata.com/program/property">Unityでキャラクターのアイテムを管理するプログラムを作る</a></li>
  <br>
  <li><a href="https://gametukurikata.com/program/propertywindow">Unityでキャラクターの持ち物画面を作成する</a></a></li>
  <br>
  <li><a href="https://gametukurikata.com/program/stop">UnityでScriptableObjectを使ってアイテムデータベースを作成する</a></li>
  <br>
  <li><a href="https://xr-hub.com/archives/16386">【Unity 入門】《第2回》敵を自動生成する（乱数・インスタンス）｜シューティングゲームを作ろう！</a></li>
  <br>
</ul>

<h3>使用アセット</h3>
<ul>
  <li>
    <a href="https://assetstore.unity.com/packages/3d/props/food/low-poly-fruit-pickups-98135#content">Low Poly Fruit Pickups</a><br>
  </li>
  <li>
    <a href="https://assetstore.unity.com/packages/2d/gui/icons/food-icons-pack-70018#content">FOOD ICONS PACK</a>
  </li>
</ul>
