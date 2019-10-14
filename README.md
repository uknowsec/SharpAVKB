# SharpAVKB

## Usage
Windows杀软对比和补丁号对比

### cmd.exe

```
> SharpAVKB.exe

Author: Uknow
Usage: SharpAVKB.exe -AV
       SharpAVKB.exe -KB
```

![](https://github.com/uknowsec/SharpAVKB/blob/master/%E5%BE%AE%E4%BF%A1%E5%9B%BE%E7%89%87_20191014205222.png)


### Cobalt Strike

```
execute-assembly /path/to/SharpAVKB.exe
```

## dll与exe打包
```
ilmerge /ndebug /target:exe /out:D:\vscode\c_test\SharpAVKB\SharpAVKB\bin\Debug\New_SharpAVKB.exe /log D:\vscode\c_test\SharpAVKB\SharpAVKB\bin\Debug\SharpAVKB.exe /log D:\vscode\c_test\SharpAVKB\SharpAVKB\bin\Debug\Newtonsoft.Json.dll /targetplatform:v4
```



## Reference: 
http://get-av.se7ensec.cn/

https://github.com/Ch1ngg/GetWindowsKernelExploitsKB
