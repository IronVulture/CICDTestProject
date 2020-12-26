<h1 align="center">
  遊戲開發CICD範例
</h1>



## 依賴的Action
| Action  | 用途  | 狀態 |
| ------------ | ------------ | ----------|
| [Checkout](https://github.com/actions/checkout "Checkout")| 將Repository checks-out 至 `$GITHUB_WORKSPACE` 下 | ![Build Status](https://github.com/actions/checkout/workflows/test-local/badge.svg)|
| <a href="https://github.com/release-drafter/release-drafter">Release Drafter</a>  | 依照Pull Reqeust的資訊，自動產生Release Note  ||
| [Actions Status Discord](https://github.com/sarisia/actions-status-discord "Actions Status Discord")  | 透過Webhook在Discord發出訊息  ||
| [Automerge-action](https://github.com/pascalgn/automerge-action "Automerge-action")  | 自動Merge Pull Request  ||
| [Remove File](https://github.com/JesseTG/rm "Remove File")  | 全平台移除檔案或資料夾  ||
| [Delete merged branch](https://github.com/SvanBoxel/delete-merged-branch "Delete merged branch")  | 移除Merge後的Branch  |![Build Status](https://github.com/SvanBoxel/delete-merged-branch/workflows/Test%20bot%20e2e/badge.svg)|
