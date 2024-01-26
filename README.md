# UTC Capstone 
# To get started...
1. Fork the directory (fork option above). This will clone the repo to your local machine and put you in the develop branch. This is important for working on new features (user auth, UI overhaul, etc.). This makes it so we do not overlap code and lose any progress.
2. Once you have clones the repo and opened it on your local machine, you will need to set up upstream. To do so, first run this command in your vscode terminal: git remote -v (If you cloned your fork via github desktop, ignore the remaining steps).
3. This should give you two lines that read the following: origin https://github.com/yourName/UTC-Capstone.git (fetch) and https://github.com/yourName/UTC-Capstone.git (push)
4. If you opened the clones repo via Github Desktop, running git remote -v may give you the above lines plus two more that have "upstream" in front of them. If so, ignore remaining steps.
5. Next, run this command: git remote add upstream git@github.com:danielduggin2/UTC-Capstone.git
6. Run git remote -v again and you should now have 4 lines similar to the two above.
7. Now upstream is set up. In the future, whenver you beign to work, run git pull upstream develop to get new changes.

# Here are some useful terminal commands for upstream
1. git pull upstream develop - pull updated code
2. git checkout -b branchName - creates a new branch. This is useful in big changes (ex: git checkout -b authentication)
3. git checkout branchName - navigate to a branch (ex: git checkout authentication)
4. git stash - If you have changes made and someone else just made changes, you will want to stash your code so when you pull the changes, you will not lose your work.
5. git stash pop - implements the changes you were previously working on
6. git stash clear - clears the stash if you do not want to use that code

# Confirmed Pull Requests
Read by Andres Cavalie <br />
Read by Halle Olson <br />
Read by Brianna Black <br />
Ready by Ethan Craig <br />
Read by Andres Angel <br />
# Getting Started with Create React App

To run the project <br />
cd website <br />
npm start

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## Available Scripts

In the project directory, you can run:

### `npm start`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in your browser.

The page will reload when you make changes.\
You may also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `npm run eject`

**Note: this is a one-way operation. Once you `eject`, you can't go back!**

If you aren't satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except `eject` will still work, but they will point to the copied scripts so you can tweak them. At this point you're on your own.

You don't have to ever use `eject`. The curated feature set is suitable for small and middle deployments, and you shouldn't feel obligated to use this feature. However we understand that this tool wouldn't be useful if you couldn't customize it when you are ready for it.

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).

### Code Splitting

This section has moved here: [https://facebook.github.io/create-react-app/docs/code-splitting](https://facebook.github.io/create-react-app/docs/code-splitting)

### Analyzing the Bundle Size

This section has moved here: [https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size](https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size)

### Making a Progressive Web App

This section has moved here: [https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app)

### Advanced Configuration

This section has moved here: [https://facebook.github.io/create-react-app/docs/advanced-configuration](https://facebook.github.io/create-react-app/docs/advanced-configuration)

### Deployment

This section has moved here: [https://facebook.github.io/create-react-app/docs/deployment](https://facebook.github.io/create-react-app/docs/deployment)

### `npm run build` fails to minify

This section has moved here: [https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify](https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify)
