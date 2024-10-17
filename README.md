# Project-Saproling

## Development guide

You can run `pre-commit run -a` to fix all files in the project. This will run automatically on `git commit`

## Dev dependencies

### Setup python virtualenv

Install python [version 3.13.0](https://www.python.org/ftp/python/3.13.0/python-3.13.0-amd64.exe)

```shell
pip install virtualenv
```

Then create a virtual environment in your project directory:

```shell
python -m venv venv
```

Which will create a directory called venv which will mirror your global python installation. Inside venv/ there will be a directory called lib which will contain Python and will store your dependencies.

Then activate the environment with:

```shell
source venv/Scripts/activate
```

Then install your dependencies with pip and they will be installed in the virtual environment venv/:

```shell
pip install -r requirements.txt
```

Then any time you return to the project, run `source venv/Scripts/activate` again so that the dependencies can be found.

To deactivate the virtual environment run `deactivate`

How to source the venv (activate file) for windows:

```powershell
.\venv\Scripts\activate.ps1
```

You might have to update your execution policies if you are using powershell to execute the activate script.

```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```

To deactivate the virtual environment run `deactivate`

### Setup pre-commit

Pre-commit is a useful tool that hooks into git and runs before you commit anything.

Among other things it is set up in this repo to fix line endings, pretty-format json files, and make sure every file is using CRLF line endings.

You can read more about it here: [pre-commit github](https://github.com/pre-commit/pre-commit-hooks)

To get started, follow the previous step on setting up your venv. Then run

```shell
pre-commit install
pre-commit install --install-hooks
```
