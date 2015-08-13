#SuperStrange

###特别声明

本项目自起始至结束所有源码全部开放，但必须保留署名权，所有资源一律网上收集，如果版权纠纷请您联系我，我会将项目中对应资源移除。

邮箱: Keyle_xiao@hotmail.com  QQ:351372404

StrangeIOC交流群: 137728654

开源项目地址: https://git.oschina.net/keyle/SuperStrange#git-readme

OSChina Git手机端下载随时跟进项目状态 https://git.oschina.net/appclient 

很高兴我们的开源项目SuperStrange从今天启动了，至于为什么叫做SuperStrange,这个“超级奇怪”的名字，其实我也不知道，就是突nao发dong灵da感kai的创意，猪脚在城市中不断的逃跑白天要躲避警察，晚上要躲避恶魔，无尽的跑酷，最终摆脱顽敌迎来短暂的自由
 

#一. 本章阐述核心玩法且不动摇

核心设定如下

设定1，玩家会沿着公路一直往前跑

设定2，玩家每次跑酷都会被计时

设定3，分为多个关卡每个都有达成目标

设定4，在跑酷时间内分为昼夜交替

设定5，白天收集攻击道具/增益道具，晚上放出怪物(需要战斗)

设定6，一个攻击道具为一个“符号”

设定7，攻击方式为 玩家画出固定道具手势，如记忆成功，则释放攻击道具，反之可能面临攻击

设定8，角色具有 天赋技能 具有能量槽 具有血量

设定9，角色可以不适用白天积累的攻击道具，使用天赋技能，消耗能量

 

#二.开发流程

1.加入QQ群，注册OSChina账号

2.如果想成为master开发者请告知我注册邮箱，方便发放开发者权限

3.成为开发者后在team中确认模块分工 https://team.oschina.net/ 

4.所有人均有权重构重写它人代码，但请留下中文注释

5.所有测试代码请存于test分支中，请勿在master中上传

6.为了有一个自由的协作开发模式，管理员不审核代码提交，Push代码之后请在team中告知

7.请勿轻易删除非本人创建代码片段，有有必要 可全文注释


###开发规范细则
命名规则：[Camel-Case(骆驼命名法)](http://baike.baidu.com/link?url=y3Syq4B7nXdn5QTN3sanj19fhC9JuQ5RhGSOmE8K_Kn25tHrXvuNotLr_9atUmRuVpfHVsPFOv41CzV1Dp8jga) 

枚举规范：使用StrangeIOC非全局事件枚举请尽量使用类内部枚举，即 在类内部定义枚举类

目录结构：如 

```
Main上下文为例
		   ------------common
		   --
           ------------controller	 
		   --
		   ------------model
		   --
		   ------------util
		   --
		   ------------view
```


#三.非盈利声明

1.本项目内除代码外任何资源禁止商用

2.代码片段作者本人对该代码有最终解释权

3.禁止任何盈利性传播，如收费倒卖源码

 

#四.最终语

希望大家能简单开始，轻轻松松的心态对待这个小游戏，欢迎入坑~

项目开发周期不定，有空便可以上去倒腾两下，欢迎过来Fork代码。

本着学习的心态来的，希望可以收获满满而归，加油 骚年 !