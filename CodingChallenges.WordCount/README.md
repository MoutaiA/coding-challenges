# Word Count CLI Tool (ccwc)

## Description

A command-line tool, `ccwc`, that counts the bytes, lines, words and characters in a text file or in standard input, following the Unix philosophy of `wc`.

## Setup

- Download the test file from the challenge page and save it as `test.txt`
- Expected values for `test.txt`:

| Count      | Option | Expected value |
|------------|--------|----------------|
| Bytes      | `-c`   | 342190         |
| Lines      | `-l`   | 7145           |
| Words      | `-w`   | 58164          |
| Characters | `-m`   | 339292         |

## Acceptance criteria

### 1. Count bytes

- `ccwc -c <file>` should output the number of bytes in the file, followed by the file name
- Example: `ccwc -c test.txt` → `  342190 test.txt`

### 2. Count lines

- `ccwc -l <file>` should output the number of lines in the file, followed by the file name
- Example: `ccwc -l test.txt` → `    7145 test.txt`

### 3. Count words

- `ccwc -w <file>` should output the number of words in the file, followed by the file name
- A word is a sequence of characters separated by whitespace
- Example: `ccwc -w test.txt` → `   58164 test.txt`

### 4. Count characters

- `ccwc -m <file>` should output the number of characters in the file, followed by the file name
- Multibyte characters (e.g. `é`, `—`) should be counted as one character
- If the locale does not support multibyte characters, the result should equal the byte count
- Example: `ccwc -m test.txt` → `  339292 test.txt`

### 5. Default behaviour

- When no option is provided, the output should be the line, word and byte counts, in that order, followed by the file name
- Example: `ccwc test.txt` → `    7145   58164  342190 test.txt`

### 6. Read from standard input

- When no file name is provided, the input should be read from standard input
- The file name should not be displayed in the output
- Options should work the same way as with a file
- Example: `cat test.txt | ccwc -l` → `    7145`
- Example: `cat test.txt | ccwc` → `    7145   58164  342190`

### 7. Edge cases

- An empty file should return `0` for every count
- A file without a trailing newline should not count its last line (matches `wc` behaviour)
- Multiple consecutive spaces, tabs or newlines should not create extra words

### 8. Error handling

- The app should fail gracefully when the file does not exist
  - Error message: `ccwc: <file>: No such file or directory`
- The app should fail gracefully when an unknown option is provided
  - Error message: `ccwc: invalid option -- '<option>'`
- In both cases, the app should exit with a non-zero exit code
