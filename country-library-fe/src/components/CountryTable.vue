<template>
  <div class="container">
    <header>
      <h1>Country List</h1>
      <button @click="startAdd">Add Country</button>
    </header>
    <main>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Country</th>
            <th>Language</th>
            <th>Capital</th>
            <th>Currency</th>
            <th>Population</th>
            <th>Edit</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="country in countries" :key="country.id">
            <td>
              <span>{{ country.id }}</span>
            </td>
            <td>
              <span v-if="!country.editing">{{ country.name }}</span>
              <input v-else v-model="country.name" />
            </td>
            <td>
              <span v-if="!country.editing">{{ country.language }}</span>
              <input v-else v-model="country.language" />
            </td>
            <td>
              <span v-if="!country.editing">{{ country.capital }}</span>
              <input v-else v-model="country.capital" />
            </td>
            <td>
              <span v-if="!country.editing">{{ country.currency }}</span>
              <input v-else v-model="country.currency" />
            </td>
            <td>
              <span v-if="!country.editing">{{ country.population }}</span>
              <input v-else v-model="country.population" />
            </td>
            <td>
              <button v-if="!country.editing" @click="startEditing(country)">Edit</button>
              <template v-else>
                <button @click="updateCountry(country)">Update</button>
                <button @click="deleteCountry(country.id)">Delete</button>
                <button @click="country.editing = false">Cancel</button>
              </template>
            </td>
          </tr>
          <template v-if="addingCountry">
            <tr>
              <td>
                <span>#</span>
              </td>
              <td>
                <input v-model="addCountry.name" />
              </td>
              <td>
                <input v-model="addCountry.language" />
              </td>
              <td>
                <input v-model="addCountry.capital" />
              </td>
              <td>
                <input v-model="addCountry.currency" />
              </td>
              <td>
                <input v-model="addCountry.population" />
              </td>
              <td>
                <button @click="AddCountry(addCountry)">add</button>
                <button @click="addingCountry = false">Cancel</button>
              </td>
            </tr>
          </template>
        </tbody>
      </table>
    </main>
  </div>
</template>

<script lang="ts">
import axios from 'axios';
import Country from '../model/Country';
import { ElButton, ElDialog } from 'element-plus';



export default {
  name: 'App',
  data() {
    return {
      // countries: Array<Country> [],
      countries: [] as Array<Country>,
      loading: false,
      dialogVisible: false, // 添加這一行
      addingCountry: false,
      addCountry: {} as Country,  // 添加這一行
      visible: false
    };
  },
  mounted() {
    this.fetchCountries();
  },
  methods: {
    async fetchCountries() {
      this.loading = true;
      try {
        const response = await axios.get('https://localhost:7252/Country/GetCountries');
        this.countries = response.data;
      } catch (error) {
        console.error('Error fetching countries:', error);
      } finally {
        this.loading = false;
      }
    },
    startEditing(country: Country) {
      // 设置编辑状态
      country.editing = true;
    },
    startAdd() {
      this.addCountry = {} as Country;
      this.addingCountry = true;
    },
    async updateCountry(country: Country) {
      // 取消编辑状态
      country.editing = false;
      try {
        await axios.post(`https://localhost:7252/Country/UpdateCountry`, country);
        this.fetchCountries();
      } catch (error) {
        console.error('Error updating country:', error);
      }
    },
    async deleteCountry(id: number) {
      try {
        await axios.post(`https://localhost:7252/Country/DeleteCountry/${id}`);
        this.fetchCountries();
      } catch (error) {
        console.error('Error deleting country:', error);
      }
    },
    async AddCountry(country: Country) {
      try {
        await axios.post(`https://localhost:7252/Country/AddCountry`, country);
        this.fetchCountries();
        this.addingCountry = false;
      } catch (error) {
        console.error('Error adding country:', error);
      }
    },
  },
};
</script>

<style>
.container {
  width: 800px;
  margin: 0 auto;
}

header {
  background-color: #ffffff;
  padding: 20px;
}

h1 {
  font-size: 24px;
}

table {
  width: 100%;
  border-collapse: collapse;
}

th,
td {
  border: 1px solid #ccc;
  padding: 10px;
}
</style>