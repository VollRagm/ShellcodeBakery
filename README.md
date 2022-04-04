# ShellcodeBakery
A simple tool to assemble shellcode ready to be copy-pasted into code

## Usage
Enter the ASM code in the left Text box. Make sure to use [FASM Syntax](https://flatassembler.net/docs.php?article=manual).  
Select the output settings and hit assemble.  
Example output when checking all 3 boxes:  
Input: 
```asm
mov rcx, 69420h
sub rsp, 20h
call rax
add rsp, 20h
cmp rax, 2
jne 0x5
```

Output:
```cpp
char shellcode[] = { 
	0x48, 0xC7, 0xC1, 0x20, 0x94, 0x06, 0x00, 	 // 0x0: mov rcx, 69420h
	0x48, 0x83, 0xEC, 0x20, 				 // 0x7: sub rsp, 20h
	0xFF, 0xD0, 						 // 0xB: call rax
	0x48, 0x83, 0xC4, 0x20, 				 // 0xD: add rsp, 20h
	0x48, 0x83, 0xF8, 0x02, 				 // 0x11: cmp rax, 2
	0x75, 0x03						 // 0x15: jne 0x5
};
```

![](https://i.imgur.com/oYTWXJ7.png)
