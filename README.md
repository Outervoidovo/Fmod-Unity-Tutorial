# Fmod-Unity-Tutorial
24/1/8

自行熟悉了一下Git相关操作流程，还是挺有挑战的；
上传的文件是我投稿在哔站的Fmod-Unity整合演示视频的原文件，仅包含Unity工程文件夹内的部分内容；
目前尚不清楚是否需要Fmod-Unity的目标文件方能正常演示播放，稍后如果查明需要就再Push一下

Unity : 2022.3.15f1c1  Fmod : 2.02.20  Fmod for Unity : 2.02.20

视频演示参见 - bilibili.com/video/BV1tS4y1n7pt
（这里呈现的视频是当前制作视频内容的第1/共9期）

-这样做分割线合适吗-

24/1/9

经过初步的资料查阅和自行摸索，在本地利用Fmod中的Assets与Build文件夹，实现了Unity端的Single Platform Build形式顺利加载；
为进一步实现脱离Fmod编辑器的项目协作等奠定了基础。

稍后我也将FmodAssetsWithBanks文件夹Push上来（按规范是否应该完成后再编辑文档？），
后续如果希望加载视频演示中使用的Fmod整合，可能需要依照如下步骤进行操作：

1 - 移步Unity Assets Store下载Fmod for Unity（计划在编辑文档完成后删除已上传的Package多余文件夹）

2 - 将此项目中的Assets, FmodAssetsWithBanks, xxx文件夹pull至本地

3 - 在整合过程中选用Single Platform Build并选择FmodAssetsWithBanks/Banks/desktop文件夹

4 - 理论上就整合完成了，尝试启用工程内的功能验证效果吧（尚未验证，如一切顺利请告知我，不胜感激）
