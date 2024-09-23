import { defineConfig } from 'vite'
import checker from 'vite-plugin-checker';
import react from '@vitejs/plugin-react'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    react(),
    checker({ typescript: { tsconfigPath: "tsconfig.app.json" }}),
  ],
  appType: 'custom',
  //publicDir: 'public',
  build: {
    manifest: true,
    emptyOutDir: false,
    outDir: "../../WebApp/wwwroot",
      rollupOptions: {
      input: [
        'index.html', // This allows the index.html to be used
        'src/main.tsx' // This references the script directly
      ]
    },
  }
})
