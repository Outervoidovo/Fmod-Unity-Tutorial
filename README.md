# Fmod-Unity-Tutorial

我正在尝试进一步摸索有关Git/Github相关操作及项目管理规范的细节，对此带来的不变还请谅解。

当前上传至Github的内容是视频演示中所使用的Unity工程（部分文件），参考相关文档理论上能够完成远端的Unity工程分享部署。
（Single Platform Build - Desktop）
所使用的软件版本为：Unity 2022.3.15f1c1, FMOD for Unity 2.02.20

理论操作如下，仅供参考：
1 - 新建Unity3D工程
2 - 前往Assets Store下载Fmod For Unity包并导入，忽略Setup Wizard等弹出窗口
3 - Git Clone文件到Unity Project文件夹并替换覆盖变更；下载zip解压导入亦可
4 - 打开Unity工程，在上方栏中选择Fmod - Edit Settings
5 - 在Settings栏打开Bank Import项目，Source Type选择Single Platform Build，Build Path选择.\FmodAssetsWithBanks\Desktop
6 - 对接成功，现在应该可以顺利浏览到预先对接的所有音频内容了。

成功整合后，具体操作请参考Fmod - Unity整合演示视频（P1，共9P）
bilibili.com/video/BV1tS4y1n7pt

欢迎提出指导建议，在此不胜感激。

2024/1/23
